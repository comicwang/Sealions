using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sealions.Core.Files
{
	/*===================================================
	 * 类名称: FileExtention
	 * 类描述: 文件操作的扩展类，主要用于文件打包用
	 * 创建人: wangchong
	 * 创建时间: 2020/9/16 16:27:53
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
	public static class FileExtention
	{
		/// <summary>
		/// 拷贝文件目录到指定目录
		/// </summary>
		/// <param name="sourceDir">原文件夹目录</param>
		/// <param name="targetDir">目标文件夹目录</param>
		public static void CopyDir(this string sourceDir, string targetDir)
		{
			if (string.IsNullOrEmpty(sourceDir) || !Directory.Exists(sourceDir))
			{
				throw new ArgumentNullException($"原目录【{sourceDir}】不存在..");
			}
			if (string.IsNullOrEmpty(targetDir))
			{
				throw new ArgumentNullException("targetDir", "目标目录不正确..");
			}
			try
			{
				if (!Directory.Exists(targetDir))
				{
					Directory.CreateDirectory(targetDir);
				}
				string[] files = Directory.GetFiles(sourceDir);
				foreach (string file in files)
				{
					string pFilePath = targetDir + "\\" + Path.GetFileName(file);
					if (File.Exists(pFilePath))
						continue;
					File.Copy(file, pFilePath, true);
				}

				string[] dirs = Directory.GetDirectories(targetDir);
				foreach (string dir in dirs)
				{
					CopyDir(dir, targetDir + "\\" + Path.GetFileName(dir));
				}
			}
			catch (Exception ex)
			{
				throw new Exception("文件拷贝异常", ex);
			}
		}

		/// <summary>
		/// 获取指定目录的文件信息
		/// </summary>
		/// <param name="Path"></param>
		/// <returns></returns>
		public static FileOrDirInfo FileInfo(this string Path)
        {
			return new FileOrDirInfo(Path);
        }

		/// <summary>
		/// 绑定文件内容到树控件
		/// </summary>
		/// <param name="treeView"></param>
		/// <param name="Path"></param>
		public static void BindDir(this TreeView treeView, string Path)
		{
			FileOrDirInfo parentInfo = Path.FileInfo();
			TreeNode parentNode = treeView.Nodes.Add(Path, parentInfo.Name);
            if (parentInfo.HasChild)
            {
				BindDir(parentInfo.Children, parentNode);
            }
			parentNode.ImageIndex = parentInfo.HasChild ? 0 : 1;
			treeView.Sort();
		}

		private static void BindDir(List<FileOrDirInfo> lstFiles,TreeNode parentNode)
        {
			foreach (var item in lstFiles)
			{
				TreeNode node = parentNode.Nodes.Add(item.Name);
				if (item.HasChild)
				{
					BindDir(item.Children, node);
				}
				node.ImageIndex = item.HasChild ? 0 : 1;
			}
		}
	
	}
}
