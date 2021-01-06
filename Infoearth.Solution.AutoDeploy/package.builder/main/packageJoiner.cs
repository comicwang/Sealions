using Sealions.Core.Files;
using Sealions.Core.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace package.builder.main
{
    /*===================================================
	 * 类名称: packageJoiner
	 * 类描述: 01Packages组装包的帮助类
	 * 创建人: wangchong
	 * 创建时间: 2020/9/17 10:22:19
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
    public class packageJoiner
    {
		/// <summary>
		/// 当前目录文件夹
		/// </summary>
		private static string CurrentDir = "01Packages";
		/// <summary>
		/// 当前目录路径
		/// </summary>
		private static string CurrentPath = string.Empty;
		/// <summary>
		/// 包源文件信息
		/// </summary>
		private static packageInfos packageInfos = null;

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="TopPath">项目根目录文件路径</param>
		internal packageJoiner(string TopPath)
		{
			if (!Directory.Exists(TopPath))
			{
				throw new ArgumentException($"目录不正确");
			}
			CurrentPath = Path.Combine(TopPath, CurrentDir);
			if (!Directory.Exists(CurrentPath))
				Directory.CreateDirectory(CurrentPath);
			packageInfos = new packageInfos();
			packageInfos.packageInfoArry = new packageInfo[0];
		}

		/// <summary>
		/// 创建一个组装类
		/// </summary>
		/// <param name="TopPath">根目录</param>
		/// <returns></returns>
		public static packageJoiner CreateJoiner(string TopPath)
        {
			return new packageJoiner(TopPath);
        }

		/// <summary>
		/// 增加包源文件
		/// </summary>
		/// <param name="info">包源文件</param>
		public void AddPackage(packageInfo info)
        {
			//拷贝文件
			info.CurrentDir.CopyDir(CurrentPath);
			//新增包源
			List<packageInfo> temp = packageInfos.packageInfoArry.ToList();
			temp.Add(info);
			packageInfos.packageInfoArry = temp.ToArray();

			SavePackageConfig();
        }

		/// <summary>
		/// 删除包源文件
		/// </summary>
		/// <param name="dirPath"></param>
		public void DeletePackage(string dirPath)
        {
			List<packageInfo> temp = packageInfos.packageInfoArry.ToList();
			if (temp.Where(t => t.CurrentDir == dirPath).Any())
			{
				temp.Remove(temp.Where(t => t.CurrentDir == dirPath).FirstOrDefault());
				packageInfos.packageInfoArry = temp.ToArray();
			}
			//删除文件夹
			Directory.Delete(dirPath, true);

			SavePackageConfig();
		}

		/// <summary>
		/// 保存Xml文件
		/// </summary>
		private void SavePackageConfig()
        {
			XmlHelper.Serialize<packageInfos>(packageInfos, CurrentPath);
		}
    }
}
