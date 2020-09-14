using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infoearth.Solution.AutoDeploy.Utility
{
    public class RegexHelper
    {
        /// <summary>
        /// 匹配Ip地址
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public bool MatchesIp(string strIn)
        {
           return Regex.IsMatch(strIn, RegexCons.IpMatchCons);
        }
    }
}
