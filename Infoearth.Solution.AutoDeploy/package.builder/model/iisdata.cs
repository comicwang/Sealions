using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace package.builder.model
{
    /*===================================================
	 * 类名称: iisdata
	 * 类描述:
	 * 创建人: wangchong
	 * 创建时间: 2020/12/24 18:25:20
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
    /// <summary>
    /// IIS发布数据信息
    /// </summary>
    public class iisdata
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
