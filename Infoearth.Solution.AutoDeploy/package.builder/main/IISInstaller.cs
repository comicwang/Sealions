using Microsoft.Web.Administration;
using Newtonsoft.Json;
using package.builder.model;
using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.ServiceProcess;

namespace package.builder.main
{
    /*===================================================
	 * 类名称: IISInstaller
	 * 类描述:
	 * 创建人: wangchong
	 * 创建时间: 2020/12/24 18:22:38
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/

    /// <summary>
    /// IIS包源的实现类
    /// </summary>
    public class IISInstaller : IpackageInstaller
    {
        /// <summary>
        /// 安装IIS包文件
        /// </summary>
        /// <param name="packageInfo"></param>
        /// <returns></returns>
        public bool Install(packageInfo packageInfo)
        {
            ServiceController service = ServiceController.GetServices("127.0.0.1").FirstOrDefault(x => x.ServiceName == "W3SVC");

            if (service is null)
            {
                throw new InvalidOperationException("服务器尚未安装 IIS 服务模块！");
            }

            if (!System.IO.Directory.Exists(packageInfo.CurrentDir))
            {
                throw new InvalidOperationException("IIS安装指定目录不存在！");
            }

            AddSecurityControll2Folder(packageInfo.CurrentDir);

            try
            {
                iisdata iisdata = JsonConvert.DeserializeObject<iisdata>(packageInfo.OtherInfo);

                ServerManager iismanager = new ServerManager();
                //判断应用程序池是否存在
                if (iismanager.ApplicationPools[iisdata.WebName] != null)
                {
                    //移除应用程序池
                    iismanager.ApplicationPools.Remove(iismanager.ApplicationPools[iisdata.WebName]);
                }
                //判断web应用程序是否存在
                if (iismanager.Sites[iisdata.WebName] != null)
                {
                    ///移除应用程序
                    iismanager.Sites.Remove(iismanager.Sites[iisdata.WebName]);
                }
                //建立web应用程序（第二个参数为安装文件的地址）
                iismanager.Sites.Add(iisdata.WebName, packageInfo.CurrentDir, iisdata.Port);

                //添加web应用程序池
                ApplicationPool pool = iismanager.ApplicationPools.Add(iisdata.WebName);
                #region 应用程序池配置

                //pool.StartMode = StartMode.AlwaysRunning;//启动模式
                pool.Recycling.PeriodicRestart.Schedule.Add(new TimeSpan(03, 00, 00));//凌晨回收一次资源
                pool.Cpu.Limit = 50000;//限制最大CPU 50%
                //pool.Cpu.Action = ProcessorAction.ThrottleUnderLoad;//竞争cpu时限制使用最大cpu 百分比
                //设置web应用程序池的Framework版本（注意版本号大小写问题）
                pool.ManagedRuntimeVersion = "v4.0";
                //设置是否启用32为应用程序
                pool.Enable32BitAppOnWin64 = true;
                ///设置专用内存限制 1G 超出释放一次
                pool.Recycling.PeriodicRestart.PrivateMemory = 512000 * 2;
                #endregion
                //设置web网站的应用程序池
                var website = iismanager.Sites[iisdata.WebName];

                website.Applications[0].ApplicationPoolName = iisdata.WebName;
                if (!string.IsNullOrEmpty(iisdata.Domain))
                {
                    string str = website.Bindings[0].Host.Split(new char[] { '.' })[0];
                    string bindingInformation = $"*:{iisdata.Port}:{str}{iisdata.Domain}";
                    website.Bindings.Add(bindingInformation, "http");
                }
                //提交更改
                iismanager.CommitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        /// <summary>
        ///为文件夹添加users用户组的完全控制权限
        /// </summary>
        /// <param name="dirPath"></param>
        private bool AddSecurityControll2Folder(string dirPath)
        {
            try
            {
                //获取文件夹信息
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                //获得该文件夹的所有访问权限
                System.Security.AccessControl.DirectorySecurity dirSecurity = dir.GetAccessControl(AccessControlSections.All);
                //设定文件ACL继承
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                //添加ereryone用户组的访问权限规则 完全控制权限
                FileSystemAccessRule everyoneFileSystemAccessRule = new FileSystemAccessRule("IIS_IUSRS", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                bool isModified = false;
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, everyoneFileSystemAccessRule, out isModified);
                //设置访问权限
                dir.SetAccessControl(dirSecurity);
                return isModified;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"文件夹添加用户权限失败:{ex.Message}");
            }
        }
    }
}
