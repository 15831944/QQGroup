using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetQQGroupMember.Models
{
    #region 获取结果对象
    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public string ec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string errcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string em { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adm_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adm_max { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string vecsize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MemsItem> mems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string svr_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string max_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string search_count { get; set; }
    }
    #endregion
}
