using Infoearth.Solution.AutoDeploy.Model;
using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Infoearth.Solution.AutoDeploy.Utility
{
    /// <summary>
    /// 网站发布帮助类
    /// </summary>
    public class PublishWebHelper
    {
        private DeployData _deployData = null;

        /// <summary>
        /// 构造函数  
        /// </summary>
        /// <param name="WebName">程序名称</param>
        /// <param name="Port">端口号</param>
        /// <param name="ServerDomainName">域名</param>
        public PublishWebHelper(DeployData deployData)
        {
            _deployData = deployData;
        }

        /// <summary>
        /// 执行发布
        /// </summary>
        /// <param name="WebsiteDirectory">发布网站目录</param>
        /// <param name="ErrorContent">发布消息</param>
        /// <returns></returns>
        public bool Execute(out string ErrorContent)
        {
            ServiceController service = ServiceController.GetServices("127.0.0.1").FirstOrDefault(x => x.ServiceName == "W3SVC");

            if (service is null)
            {
                ErrorContent = "服务器尚未安装 IIS 服务模块！";
                return false;
            }

            if (!System.IO.Directory.Exists(_deployData.Dirctory))
            {
                ErrorContent = "指定目录不存在！";
                return false;
            }

            if (!AddSecurityControll2Folder(_deployData.Dirctory))
            {
                ErrorContent = "增加IIS用户权限失败！";
                return false;
            }

            try
            {
                ServerManager iismanager = new ServerManager();
                //判断应用程序池是否存在
                if (iismanager.ApplicationPools[_deployData.WebName] != null)
                {
                    //移除应用程序池
                    iismanager.ApplicationPools.Remove(iismanager.ApplicationPools[_deployData.WebName]);
                }
                //判断web应用程序是否存在
                if (iismanager.Sites[_deployData.WebName] != null)
                {
                    ///移除应用程序
                    iismanager.Sites.Remove(iismanager.Sites[_deployData.WebName]);
                }
                //建立web应用程序（第二个参数为安装文件的地址）
                iismanager.Sites.Add(_deployData.WebName, _deployData.Dirctory, _deployData.Port);

                //添加web应用程序池
                ApplicationPool pool = iismanager.ApplicationPools.Add(_deployData.WebName);
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
                var website = iismanager.Sites[_deployData.WebName];

                website.Applications[0].ApplicationPoolName = _deployData.WebName;
                if (!string.IsNullOrEmpty(_deployData.Domain))
                {
                    string str = website.Bindings[0].Host.Split(new char[] { '.' })[0];
                    string bindingInformation = $"*:{_deployData.Port}:{str}{_deployData.Domain}";
                    website.Bindings.Add(bindingInformation, "http");
                }
                //提交更改
                iismanager.CommitChanges();
            }
            catch (Exception ex)
            {
                ErrorContent = ex.Message;
                return false;
            }
            ErrorContent = "部署成功";
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
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
