using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealion.Model
{
	/*===================================================
	 * 类名称: PackageInfo
	 * 类描述:
	 * 创建人: wangchong
	 * 创建时间: 2020/12/25 17:14:51
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
	public class PackageInfo : ModelBase
	{
		/// <summary>
		/// 所属项目ID
		/// </summary>
		public ProjectInfo prjInfo { get; set; }
		/// <summary>
		/// 当前包的类型
		/// </summary>
		public PackageType PType { get; set; }
		/// <summary>
		/// 当前包的其他信息内容
		/// </summary>
		public string OtherInfo { get; set; }

		public override ModelType ModelType { get { return ModelType.pck; } }

		public override string VirturePath { get { return $"{prjInfo.Name}\\{base.Name}"; } }
	}

	/// <summary>
	/// 包源类型
	/// </summary>
	public enum PackageType
	{
		/// <summary>
		/// 用于IIS站点发布的包源类型
		/// </summary>
		IIS = 0,
		/// <summary>
		/// 用于直接执行的后台程序，可以为exe，也可以为bat等
		/// </summary>
		Backage = 1,
		/// <summary>
		/// Sql脚本文件，用于执行初始化数据库脚本的文件
		/// </summary>
		Sql = 2
	}
}
