using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetQQGroupMember.Models;

namespace GetQQGroupMember
{
    public partial class frmNewList : Form
    {

        Timer tmsl = new Timer();//获取当前登录人信息
        BindingSource bsdgv = null;
        List<NewQQModel> dbm = null;
        private Dictionary<string, string> _dicGroup;
        private WebBrowser _webBrowser;
        Dictionary<string, List<string>> _diclistMsg;
        private List<string> _isFirstMsg;
        public frmNewList(WebBrowser webBrowser, Dictionary<string, string> dicGroup)
        {
            InitializeComponent();
            _webBrowser = webBrowser;
            _dicGroup = dicGroup;
            _diclistMsg = new Dictionary<string, List<string>>();
            _isFirstMsg = new List<string>();
            SetNewList();
            tmsl.Interval = 60000;
            tmsl.Tick += ShowNewList;
            tmsl.Start();
        }

        private void SetNewList() {
            if (bsdgv == null) {
                bsdgv = new BindingSource();
            }
            if (dbm == null) {
                dbm = new List<NewQQModel>();
            }
            bsdgv.DataSource = new List<NewQQModel>();
            bsdgv.DataSource = dbm;
            dgvNewList.DataSource = bsdgv;
        }
      private delegate void dlgt();
        dlgt dg = null;
        #region 显示新增历史列表
        private void ShowNewList(object sender, EventArgs e)
        {
            getNewList();
            SetNewList();
        }
        #endregion

        #region 获取列表数据
        private void getNewList() {
            if (dbm == null)
            {
                dbm = new List<NewQQModel>();
            }

            foreach (string item in _dicGroup.Keys)
            {
                string resultStr = HelperAction.Get(0, 40, _dicGroup[item], _webBrowser);
                string[] eqq = resultStr.Split(',');
                List<string> lstr = new List<string>();
                List<string> lsal = new List<string>();
                List<string> lsre = new List<string>();
                if (_diclistMsg.ContainsKey(_dicGroup[item]))
                {
                    lstr = _diclistMsg[_dicGroup[item]];
                }
                else
                {
                    _diclistMsg.Add(_dicGroup[item], lstr);
                }
                foreach (string qq in eqq)
                {
                    if (string.IsNullOrEmpty(qq))
                    {
                        continue;
                    }
                    lsal.Add(qq);
                    if (!lstr.Contains(qq))
                    {
                        lstr.Add(qq);
                        if (_isFirstMsg.Contains(_dicGroup[item]))
                        {

                            var MaxNo = 0;
                            if (dbm.Count > 0)
                            {
                                dbm.Max(c => c.No);
                            }
                            NewQQModel nqm = new NewQQModel()
                            {
                                No = MaxNo + 1,
                                GroupName = item,
                                QQ = qq,
                                JoinDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            };
                            dbm.Add(nqm);
                        }
                    }
                }
                foreach (string num in lstr)
                {
                    if (!lsal.Contains(num))
                    {
                        lsre.Add(num);
                    }
                }
                foreach (string num in lsre)
                {
                    lstr.Remove(num);
                    var ml = dbm.FirstOrDefault(c => c.QQ == num);
                    if (ml != null)
                    {
                        dbm.Remove(ml);
                    }
                }
                if (!_isFirstMsg.Contains(_dicGroup[item]))
                {
                    _isFirstMsg.Add(_dicGroup[item]);
                }
            }
        }
        #endregion


        protected override void OnClosing(CancelEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (tmsl != null) {
                tmsl.Stop();
                tmsl.Dispose();
            }
        }

    }
}
