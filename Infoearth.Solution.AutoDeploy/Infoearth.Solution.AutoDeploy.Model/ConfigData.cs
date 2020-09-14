using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoearth.Solution.AutoDeploy.Model
{
    /// <summary>
    /// 配置文件数据
    /// </summary>
    public class ConfigData
    {
        /// <summary>
        /// 发布文件名称
        /// </summary>
        public string WebName { get; set; }

        /// <summary>
        /// 配置文件全路径
        /// </summary>
        public string ConfigPath { get; set; }

        /// <summary>
        /// 配置文件类型
        /// </summary>
        public ConfigType TypeVal { get; set; }

        /// <summary>
        /// 键
        /// </summary>
        public string KeyVal { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string ValueVal { get; set; }

    }

    /// <summary>
    /// 配置文件类型
    /// </summary>
    public enum ConfigType
    {
        appSettings,
        connectionStrings,
        Redis,
        Map,
        Log4Net,
        Multimedia,
        Other
    }
}
