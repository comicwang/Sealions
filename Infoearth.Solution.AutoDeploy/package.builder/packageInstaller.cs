using package.builder.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace package.builder
{
    /*===================================================
	 * 类名称: packageInstaller
	 * 类描述:
	 * 创建人: wangchong
	 * 创建时间: 2020/12/24 18:53:52
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/

    /// <summary>
    /// 包源安装类
    /// </summary>
    public static class packageInstaller
    {
        /// <summary>
        /// 安装包
        /// </summary>
        /// <param name="packageInfo"></param>
        /// <returns></returns>
        public static bool Install(this packageInfo packageInfo)
        {
            if (packageInfo == null)
            {
                return false;
            }
            IpackageInstaller ipackageInstaller = new IISInstaller();
            switch (packageInfo.PType)
            {
                case PackageType.IIS:
                    break;
                case PackageType.Backage:
                    break;
                case PackageType.Sql:
                    break;
                default:
                    break;
            }
            return ipackageInstaller.Install(packageInfo);
        }
    }
}
