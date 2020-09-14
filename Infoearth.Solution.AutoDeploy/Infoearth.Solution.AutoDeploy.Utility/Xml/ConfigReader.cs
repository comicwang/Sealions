using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Infoearth.Solution.AutoDeploy.Utility
{
    /// <summary>
    /// 配置文件读取
    /// </summary>
    public class ConfigReader
    {
        private string _filePath = string.Empty;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath"></param>
        public ConfigReader(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// 获取配置文件对象
        /// </summary>
        /// <returns></returns>
        public Configuration GetConfig()
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap()
            {
                ExeConfigFilename = _filePath
            };

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

            return config;
        }

        /// <summary>
        /// 读取配置文件节点
        /// </summary>
        /// <param name="section"></param>
        /// <param name="matches"></param>
        /// <returns></returns>
        public Dictionary<string, string> ReadConfig(string section, string matches)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            Configuration config = GetConfig();
            ConfigurationSection cSection = config.GetSection(section);
            AppSettingsSection apps = (AppSettingsSection)cSection;

            foreach (KeyValueConfigurationElement kv in apps.Settings)
            {
                if (!string.IsNullOrEmpty(matches))
                {
                    bool regular = System.Text.RegularExpressions.Regex.IsMatch(kv.Value, matches);
                    if (!regular)
                    {
                        continue;
                    }
                }
                result.Add(kv.Key, kv.Value);
            }
            return result;
        }
    }
}
