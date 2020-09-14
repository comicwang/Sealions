using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Infoearth.Solution.AutoDeploy.Utility
{
    /// <summary>
    /// xml文件序列化
    /// </summary>
    public class XmlSerializion
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xPath"></param>
        /// <returns></returns>
        public static T DeSerializion<T>(string xPath)
        {
            try
            {
                if (File.Exists(xPath))
                {
                    using (StreamReader reader = new StreamReader(xPath))
                    {
                        XmlSerializer xmldes = new XmlSerializer(typeof(T));
                        object result = xmldes.Deserialize(reader);
                        if (result == null)
                        {
                            return default(T);
                        }
                        return (T)result;
                    }
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="xPath"></param>
        public static void Seralize<T>(T obj, string xPath)
        {
            try
            {
                using (FileStream stream = new FileStream(xPath, FileMode.Create))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(stream, obj);
                    stream.Flush();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
