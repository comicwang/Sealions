using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealions.Core.Files
{
    /*===================================================
	 * 类名称: FileOrDirInfo
	 * 类描述: 文件或者目录内容
	 * 创建人: wangchong
	 * 创建时间: 2020/9/16 16:51:42
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
    public class FileOrDirInfo
    {
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="path"></param>
		public FileOrDirInfo(string path)
        {
			this.Path = path;
        }
		/// <summary>
		/// 物理路径
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// 文件夹或者目录名称
		/// </summary>
		public string Name
		{
			get
			{
				return System.IO.Path.GetFileName(Path);
			}
		}

		/// <summary>
		/// 是否是文件
		/// </summary>
		public bool IsFile { get { return File.Exists(Path);  } }

		/// <summary>
		/// 如果是文件返回文件的后缀名称，否则为空
		/// </summary>
		public string Ext
		{
			get
			{
				if (IsFile)
					return System.IO.Path.GetExtension(Path);
				return string.Empty;
			}
		}

		/// <summary>
		/// 是否有文件
		/// </summary>
		public bool HasChild 
		{
            get
            {
				return !IsFile;
            }
		}

		/// <summary>
		/// 如果是目录为子内容，否则为空
		/// </summary>
		public List<FileOrDirInfo> Children
        {
            get
            {
                if (IsFile)
                {
					return new List<FileOrDirInfo>();
                }
                else
                {
					List<FileOrDirInfo> result = new List<FileOrDirInfo>();
					string[] files = Directory.GetFiles(Path);
					Array.ForEach(files, t => result.Add(new FileOrDirInfo(t)));
					string[] dirs = Directory.GetDirectories(Path);
					Array.ForEach(dirs, t => result.Add(new FileOrDirInfo(t)));
					return result;
				}
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
