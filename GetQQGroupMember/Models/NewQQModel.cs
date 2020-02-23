using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetQQGroupMember.Models
{

    #region 新增成员对象
    public class NewQQModel
    {
        public int No { get; set; }
        public string GroupName { get; set; }
        public string QQ { get; set; }
        public string JoinDateTime { get; set; }
    }

    #endregion
}
