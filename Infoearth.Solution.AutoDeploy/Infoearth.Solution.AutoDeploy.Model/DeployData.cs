using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoearth.Solution.AutoDeploy.Model
{
    /// <summary>
    /// IIS发布数据信息
    /// </summary>
    public class DeployData
    {
        /// <summary>
        /// 目录地址
        /// </summary>
        public string Dirctory { get; set; }

        /// <summary>
        /// Web名称
        /// </summary>
        public string WebName { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public short Port { get; set; }

        /// <summary>
        /// 是否发布
        /// </summary>
        public bool Deploy { get; set; }

        /// <summary>
        /// 域名地址
        /// </summary>
        public string Domain { get; set; }
    }
}
