using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace package.builder
{
    /*===================================================
	 * 类名称: packageInfo
	 * 类描述:包文件信息
	 * 创建人: wangchong
	 * 创建时间: 2020/9/17 16:33:13
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
	[XmlRoot("packageInfo")]
    public class packageInfo
    {
		/// <summary>
		/// 当前包的目录路径
		/// </summary>
		[XmlElement("CurrentDir")]
		public string CurrentDir { get; set; }

		/// <summary>
		/// 当前包的名称
		/// </summary>
		[XmlElement("PackageName")]
		public string PackageName { get { return Path.GetFileName(CurrentDir); } }

		/// <summary>
		/// 当前包的类型
		/// </summary>
		[XmlElement("PType")]
		public PackageType PType { get; set; }
    }

	/// <summary>
	/// 包源文件集合
	/// </summary>
	[XmlRoot("package")]
	public class packageInfos
    {
		[XmlArray("packageInfos")]
		public packageInfo[] packageInfoArry { get; set; }
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
