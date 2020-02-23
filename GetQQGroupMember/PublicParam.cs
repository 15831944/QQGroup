using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetQQGroupMember
{
   public class PublicParam
    {
        //qq群成果获取接口地址
        public static string httpurl = ConfigurationManager.AppSettings["httpurl"];
        //qq群获取接口地址
        public static string getgroupurl = ConfigurationManager.AppSettings["getgroupurl"];

    }
}
