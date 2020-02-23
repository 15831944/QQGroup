using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetQQGroupMember.Models
{
    #region 接口参数对象
    public class MemsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string uin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string flag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string g { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string join_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string last_speak_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Lv Lv { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string nick { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string qage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rm { get; set; }
    }
    #endregion
}
