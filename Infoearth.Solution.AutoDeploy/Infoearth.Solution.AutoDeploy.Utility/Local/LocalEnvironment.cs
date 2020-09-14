using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.ComponentModel;

namespace Infoearth.Solution.AutoDeploy.Utility
{
    /// <summary>
    /// 用于收集本机的环境信息
    /// 相对固定的属性
    /// </summary>
    public partial class LocalEnvironment
    {

        /// <summary>
        /// 电脑的名称
        /// </summary>
        [CategoryAttribute("Computer"), DescriptionAttribute("主机名")]
        public string HostName
        {
            get
            {
                return Environment.MachineName;
            }
        }
        /// <summary>
        /// 程序运行的当前用户名。
        /// </summary>
        [CategoryAttribute("Computer"), DescriptionAttribute("用户名")]
        public string UserName
        {
            get
            {
                return Environment.UserName;
            }
        }
        /// <summary>
        /// CPU的核数
        /// </summary>
        [CategoryAttribute("Computer"), DescriptionAttribute("CPU核")]
        public int ProcessorCount
        {
            get
            {
                return Environment.ProcessorCount;
            }
        }
        ///// <summary>
        ///// 当前系统的内存（M）
        ///// </summary>
        //public static int HostWorkingSet
        //{
        //    get
        //    {

        //        return (int)((Environment.WorkingSet / 1024) / 1024);
        //    }
        //}

        private static string _HostIP;
        /// <summary>
        /// 本机内网IP，若无，则返回主机名
        /// </summary>
        [CategoryAttribute("Computer"), DescriptionAttribute("IP地址")]
        public  string HostIP
        {
            get
            {
                if (string.IsNullOrEmpty(_HostIP))
                {
                    IPAddress[] addressList = Dns.GetHostAddresses(HostName);
                    foreach (IPAddress address in addressList)
                    {
                        string ip = address.ToString();
                        if (ip.EndsWith(".1") || ip.Contains(":")) // 忽略路由和网卡地址。
                        {
                            continue;
                        }
                        _HostIP = ip;
                        break;
                    }
                }
                return _HostIP ?? HostName;
            }
        }

    }
    /// <summary>
    /// 变化的部分属性
    /// </summary>
    public partial class LocalEnvironment
    {
        /// <summary>
        /// 当前进程占用的内存（M）
        /// </summary>
        [CategoryAttribute("Current"), DescriptionAttribute("所占内存")]
        public int ProcessWorkingSet
        {
            get
            {
                return (int)((Environment.WorkingSet / 1024) / 1024);
                // System.Diagnostics.p
            }
        }
        //CPU占用率

    }
}
