using Sealions.Core.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sealion.Model
{
    /*===================================================
	 * 类名称: OprateBase
	 * 类描述:
	 * 创建人: wangchong
	 * 创建时间: 2020/12/25 15:46:28
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
    public class OprateBase<T> where T:ModelBase,new()
    {
		public bool Save(T modelBase)
        {
            string prjPath = Path.Combine(Application.StartupPath, "Data", modelBase.VirturePath);
            switch (modelBase.ModelType)
            {
                case ModelType.prj:
                    if (string.IsNullOrEmpty(modelBase.Id))
                        modelBase.Id = Guid.NewGuid().ToString();                    
                    if (Directory.Exists(prjPath) == false)
                        Directory.CreateDirectory(prjPath);
                    XmlHelper.Serialize<T>(modelBase, Path.Combine(prjPath, "prjMetaInfo.xml"));
                    break;
                case ModelType.pck:
                    if (string.IsNullOrEmpty(modelBase.Id))
                        modelBase.Id = Guid.NewGuid().ToString();
                    if (Directory.Exists(prjPath) == false)
                        Directory.CreateDirectory(prjPath);
                    XmlHelper.Serialize<T>(modelBase, Path.Combine(prjPath, "pakMetaInfo.xml"));
                    break;
                case ModelType.cnf:
                    break;
                default:
                    break;
            } 
			return true;
        }

        public List<T> GetList<T1>(T1 modelParent, string keyWord = null) where T1 : ModelBase, new()
        {
            List<T> result = new List<T>();
            string prjPath = Path.Combine(Application.StartupPath, "Data", modelParent.VirturePath);
            string[] files = null;
            T temp = new T();
            switch (temp.ModelType)
            {
                case ModelType.prj:

                    files = Directory.GetFiles(prjPath, "prjMetaInfo.xml", SearchOption.AllDirectories);
                    break;
                case ModelType.pck:
                    files = Directory.GetFiles(prjPath, "pakMetaInfo.xml", SearchOption.AllDirectories);
                    break;
                case ModelType.cnf:
                    break;
                default:
                    break;
            }
            foreach (var file in files)
            {
                T t = XmlHelper.Deserialize<T>(file);
                if (!string.IsNullOrEmpty(keyWord))
                {
                    if (t.Name.Contains(keyWord))
                        result.Add(t);
                }
                else
                    result.Add(t);
            }

            return result;
        }

		public bool Delete(T modelBase)
        {
            string prjPath = Path.Combine(Application.StartupPath, "Data", modelBase.VirturePath);
            Directory.Delete(prjPath,true);           
            return true;
        }
    }
}
