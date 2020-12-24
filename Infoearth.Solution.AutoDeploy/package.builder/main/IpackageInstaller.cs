using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace package.builder.main
{
	/*===================================================
	 * 类名称: packageInstaller
	 * 类描述:包源安装引擎
	 * 创建人: wangchong
	 * 创建时间: 2020/12/24 17:26:31
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
	public interface IpackageInstaller
	{
		/// <summary>
		/// 安装包源文件
		/// </summary>
		/// <param name="packageInfo"></param>
		/// <returns></returns>
		bool Install(packageInfo packageInfo);
	}
}
