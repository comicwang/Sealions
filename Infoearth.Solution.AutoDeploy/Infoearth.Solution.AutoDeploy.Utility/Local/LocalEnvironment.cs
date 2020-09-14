using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.ComponentModel;

namespace Infoearth.Solution.AutoDeploy.Utility
{
    /// <summary>
    /// �����ռ������Ļ�����Ϣ
    /// ��Թ̶�������
    /// </summary>
    public partial class LocalEnvironment
    {

        /// <summary>
        /// ���Ե�����
        /// </summary>
        [CategoryAttribute("Computer"), DescriptionAttribute("������")]
        public string HostName
        {
            get
            {
                return Environment.MachineName;
            }
        }
        /// <summary>
        /// �������еĵ�ǰ�û�����
        /// </summary>
        [CategoryAttribute("Computer"), DescriptionAttribute("�û���")]
        public string UserName
        {
            get
            {
                return Environment.UserName;
            }
        }
        /// <summary>
        /// CPU�ĺ���
        /// </summary>
        [CategoryAttribute("Computer"), DescriptionAttribute("CPU��")]
        public int ProcessorCount
        {
            get
            {
                return Environment.ProcessorCount;
            }
        }
        ///// <summary>
        ///// ��ǰϵͳ���ڴ棨M��
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
        /// ��������IP�����ޣ��򷵻�������
        /// </summary>
        [CategoryAttribute("Computer"), DescriptionAttribute("IP��ַ")]
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
                        if (ip.EndsWith(".1") || ip.Contains(":")) // ����·�ɺ�������ַ��
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
    /// �仯�Ĳ�������
    /// </summary>
    public partial class LocalEnvironment
    {
        /// <summary>
        /// ��ǰ����ռ�õ��ڴ棨M��
        /// </summary>
        [CategoryAttribute("Current"), DescriptionAttribute("��ռ�ڴ�")]
        public int ProcessWorkingSet
        {
            get
            {
                return (int)((Environment.WorkingSet / 1024) / 1024);
                // System.Diagnostics.p
            }
        }
        //CPUռ����

    }
}
