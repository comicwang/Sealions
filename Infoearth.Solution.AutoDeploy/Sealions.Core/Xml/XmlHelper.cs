using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sealions.Core.Xml
{
    /*===================================================
	 * 类名称: XmlHelper
	 * 类描述: Xml文件操作的帮助类
	 * 创建人: wangchong
	 * 创建时间: 2020/9/17 17:37:09
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
    public class XmlHelper
    {
        /// <summary>
        /// 将xml文件序列化为实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string xmlPath) where T : class
        {
            if (File.Exists(xmlPath))
            {
                //解决文件占用的问题
                while (true)
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(xmlPath))
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(T));
                            return xs.Deserialize(reader) as T;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            return default(T);
        }

        /// <summary>
        /// 将实体存储到xml文件中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="xmlPath"></param>
        public static void Serialize<T>(T obj, string xmlPath) where T : class
        {
            using (StreamWriter writer = new StreamWriter(xmlPath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(writer, obj);
            }
        }
    }
}
