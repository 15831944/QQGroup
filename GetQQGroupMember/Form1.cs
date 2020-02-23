using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Xml;
using System.Web.Script.Serialization;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using GetQQGroupMember.Models;
namespace GetQQGroupMember
{
    public partial class Form1 : Form
    {
        #region 全局变量
        private string bkn;
        private List<string> listGroup;
        private Dictionary<string, string> dicGroup;
        private List<string> isFirstMsg;
        Dictionary<string, List<string>> diclistMsg;
        private List<string> listQQ;
        private List<string> listNewQQ;
        private static string groupNumber;
        private List<string> isFirst;
        private static string cQQ;
        Timer tm = new Timer();//获取群员信息
        Timer tmer = new Timer();//获取当前登录人信息
        Timer tmgn = new Timer();//获取当前登录人信息
        Dictionary<string, List<string>> diclist = new Dictionary<string, List<string>>();

        frmNewList fnl = null;

        private static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        #endregion
        #region 重写开始方法
        public Form1()
        {
            InitializeComponent();
            //初始化时，为webbrowser的url赋值，访问页面
            webBrowser1.Url = new Uri(ConfigurationManager.AppSettings["loginurl"]);            
            //要获取成员的群号
            //groupNumber = ConfigurationManager.AppSettings["gc"];
            //GetSource();
            isFirst = new List<string>();
            isFirstMsg = new List<string>();
            if (listGroup != null && listGroup.Count > 0)
            {
                groupNumber = dicGroup.Values.FirstOrDefault();
            }

            tmer.Interval = 10000;
            if (string.IsNullOrEmpty(cQQ))
            {
                tmer.Tick += getCreateQQ;
                tmer.Start();
            }
            tmgn.Interval = 30000;
            tmgn.Tick += MsgNewQQ;
            tm.Tick += btn_start_Click;
            tm.Interval = 30000;

            dgvGroup.CellClick += onCellCileck;

        }
        #endregion
     
       
        #region 选中群事件
        private void onCellCileck(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                var cell = dgvGroup.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell != null && cell.Value != null)
                {
                    string value = cell.Value.ToString();
                    if (dicGroup.ContainsKey(value))
                    {

                        groupNumber = dicGroup[value];
                    }
                }
            }

        }
        #endregion
        #region 设置列表数据
        private void SetDate()
        {
            dgvQQ.DataSource =HelperAction.getModelList(listQQ);
            dgvNewQQ.DataSource = HelperAction.getModelList(listNewQQ);
        }
        #endregion
      
     
        #region 获取当前登录QQ
        private void getCreateQQ(object sender, EventArgs e)
        {
            cQQ = HelperAction.getCreateQQ(webBrowser1);
        }
        #endregion
        #region 监测当前选中群中人员和新增人员
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(groupNumber)) { return; }
            //判断目标群号是否为空
            if (string.IsNullOrEmpty(groupNumber))
            {
                MessageBox.Show("QQ群号不能为空！");
                return;
            }
           string resultStr = HelperAction.Get(0, 40, groupNumber, webBrowser1);
            GetQQList(resultStr);
            SetDate();
        }
        #endregion
        #region 新增人员提示
        private void MsgNewQQ(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bkn))
            {
                HelperAction.getBkn(webBrowser1);
            }
            foreach (string item in dicGroup.Keys)
            {
                string resultStr = HelperAction.Get(0, 40, dicGroup[item],webBrowser1);
                string[] eqq = resultStr.Split(',');
                List<string> lstr = new List<string>();
                List<string> lsal = new List<string>();
                List<string> lsre = new List<string>();
                if (diclistMsg.ContainsKey(dicGroup[item]))
                {
                    lstr = diclistMsg[dicGroup[item]];
                }
                else
                {
                    diclistMsg.Add(dicGroup[item], lstr);
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
                        if (isFirstMsg.Contains(dicGroup[item]))
                        {
                            MessageBox.Show("群：" + item + " 用户：" + qq + "新增！");
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
                }
                if (!isFirstMsg.Contains(dicGroup[item]))
                {
                    isFirstMsg.Add(dicGroup[item]);
                }
            }

        }
        #endregion
        #region 获取群集合
        //获取qq号的方法
        private void GetQQList(string qqs)
        {

            if (listQQ == null) listQQ = new List<string>();
            if (listNewQQ == null) listNewQQ = new List<string>();
            if (qqs.Length < 1) { return; }
            string[] eqq = qqs.Split(',');
            List<string> lslt = new List<string>();
            List<string> relt = new List<string>();
            foreach (string item in eqq)
            {
                lslt.Add(item);
                if (!listQQ.Contains(item))
                {
                    listQQ.Add(item);
                    if (isFirst.Contains(groupNumber))
                    {
                        if (!listNewQQ.Contains(item))
                        {
                            listNewQQ.Add(item);
                        }
                    }
                }

            }
            foreach (string item in listQQ)
            {
                if (!lslt.Contains(item))
                {
                    relt.Add(item);
                }
            }
            foreach (string item in relt)
            {
                listQQ.Remove(item);
                if (listNewQQ.Contains(item))
                {
                    listNewQQ.Remove(item);
                }
            }
            if (!isFirst.Contains(groupNumber))
            {
                isFirst.Add(groupNumber);
            }
        }
        #endregion

        #region 获取xml格式文件内容
        private void GetSource()
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (File.Exists("XMLConfig.xml"))
            {
                xmlDocument.Load("XMLConfig.xml");
            }
            listGroup = new List<string>();
            dicGroup = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(cQQ)) { return; }
            XmlNode xmlNode = xmlDocument.SelectSingleNode("Root");
            if (xmlNode == null) { return; }
            XmlNode xmlQQ = xmlNode.SelectSingleNode(cQQ);
            if (xmlQQ == null) { return; }
            var qqgroups = xmlQQ.SelectNodes("QQGroup");
            foreach (XmlNode node in qqgroups)
            {
                var ats = node.Attributes;
                string groupNum = ats.GetNamedItem("GroupNum").Value.ToString();
                string groupName = ats.GetNamedItem("GroupName").Value.ToString();
                dicGroup.Add(groupName, groupNum);
                listGroup.Add(groupName);
            }
            dgvGroup.DataSource = HelperAction.getModelList(listGroup);
        }

        #endregion
      
        #region 监测当前选中群信息开始事件
        private void BtnStart_Click(object sender, EventArgs e)
        {
            tm.Start();
        }
        #endregion
        #region 监测当前选中群信息停止事件
        private void BtnStop_Click(object sender, EventArgs e)
        {
            tm.Stop();
        }
        #endregion
        #region 获取当前QQ的群列表
        private void BtnGetGroup_Click(object sender, EventArgs e)
        {
            HelperAction.GetGroup(out listGroup,out dicGroup, webBrowser1);
            dgvGroup.DataSource = HelperAction.getModelList(listGroup);
        }
        #endregion
        #region 监测群新增成员开始事件
        private void BtnMsgStart_Click(object sender, EventArgs e)
        {
            tmgn.Start();
        }
        #endregion
        #region 监测群新增成员停止事件
        private void BtnMsgStop_Click(object sender, EventArgs e)
        {
            tmgn.Stop();
        }
        #endregion

        public delegate void dlgt();
        #region 显示新增成员历史列表
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (fnl == null) { fnl = new frmNewList(webBrowser1,dicGroup); }
            fnl.ShowDialog();
            if (fnl.DialogResult == DialogResult.OK) {
                this.Show();
            }
        }
        #endregion
        protected override void OnClosing(CancelEventArgs e)
        {
            if (tm != null) { tm.Stop(); tm.Dispose(); }
            if (tmer != null) { tmer.Stop(); tmer.Dispose(); }
            if (tmgn != null) { tmgn.Stop(); tmgn.Dispose(); }
        }

    }


   
    


}
