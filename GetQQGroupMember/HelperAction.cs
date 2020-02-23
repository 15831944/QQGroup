using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using GetQQGroupMember.Models;
using Newtonsoft.Json;

namespace GetQQGroupMember
{
    public class HelperAction
    {
        #region 访问接口获取群成员
        /// <summary>
        /// httpClinet -Get 方法
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string Get(int st, int end, string groupnum,WebBrowser webBrowser)
        {
            string result = "";
            string qqs = "";
           string url = PublicParam.httpurl+string.Format("?gc={0}&st={1}&end={2}&sort=0&bkn={3}", groupnum, st, end,getBkn(webBrowser));
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.Headers["Accept-Language"] = "zh-CN,zh;q=0.9";
            req.Referer = "http://qun.qq.com/member.html";
            req.Headers["cookie"] = webBrowser.Document.Cookie;
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容 
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                stream.Close();
            }
            if (!string.IsNullOrEmpty(result))
            {
                qqs += GetQQs(result, groupnum,st,end, qqs,webBrowser);
            }
            return qqs;
        }
        #endregion
        #region 群成员字符串
        public static string GetQQs(string jsons, string groupnum,int pageSt,int pageEnd,string rStr,WebBrowser webBrowser)
        {
            //Root是对qq群号接口返回json的解析的bean对象，反序列化json
            Root root = JsonConvert.DeserializeObject<Root>(jsons);
            //在此处判断是否登录了
            if (root.mems == null)
            {
                return "";
            }
            //遍历json对象，拼接qq号字符串
            if (int.Parse(root.count) < pageEnd + 1)
            {
                for (int j = 0; j < root.mems.Count - 1; j++)
                {
                    rStr += root.mems[j].uin + ",";
                }
                rStr += root.mems[root.mems.Count - 1].uin;
            }
            else
            {
                for (int j = 0; j < root.mems.Count; j++)
                {
                    rStr += root.mems[j].uin + ",";
                }
            }
            //因为该接口每次只能获取41个qq号，需要判断是否已经到最后一批，如果不是那么递归调用，重新获取
            if (int.Parse(root.count) > pageEnd + 1)
            {
                pageSt = pageEnd + 1;
                pageEnd += 41;
                Get(pageSt, pageEnd, groupnum,webBrowser);
            }
            return rStr;
        }
        #endregion
        #region 获取bkn
        public static string getBkn(WebBrowser webBrowser)
        {
            string bkn = "";
            if (webBrowser.Document != null && webBrowser.Document.Cookie != null)
            {
                //获取已存在的cookie
                string cookie = webBrowser.Document.Cookie;
                string[] cookstr = cookie.Split(';');
                foreach (string str in cookstr)
                {
                    //通过计算，解析skey值得到bkn特征值
                    if (str.Trim().IndexOf("skey") == 0)
                    {
                        string[] cookieNameValue = str.Split('=');
                        //以下算法从web js中获取，不同的qq登陆站点可能需要的参数并不一致
                        if (!string.IsNullOrEmpty(cookieNameValue[1]))
                        {
                            int t = 5381;
                            for (int r = 0, n = cookieNameValue[1].Length; r < n; ++r)
                            {
                                t += (t << 5) + (CharAt(cookieNameValue[1], r).ToCharArray()[0] & 0xff);
                            }
                            bkn = (2147483647 & t).ToString();
                            break;
                        }
                    }
                }
            }
            return bkn;
        }
        #endregion
        #region 获取字符串指定位置的字符
        /// <summary>
        /// 获取字符串指定位置的字符
        /// </summary>
        /// <param name="s">源字符串</param>
        /// <param name="index">索引位置</param>
        /// <returns>某个字符</returns>
        public static string CharAt(string s, int index)
        {
            if ((index >= s.Length) || (index < 0))
                return "";
            return s.Substring(index, 1);
        }
        #endregion

        #region 获取当前QQ的群列表
        public static void GetGroup(out List<string> listGroup, out Dictionary<string, string> dicGroup, WebBrowser webBrowser)
        {
                listGroup = new List<string>();
                dicGroup = new Dictionary<string, string>();
            string result = "";
            string url =PublicParam.getgroupurl+string.Format("?bkn={0}", getBkn(webBrowser));
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.Headers["Accept-Language"] = "zh-CN,zh;q=0.9";
            req.Referer = "http://qun.qq.com/member.html";
            req.Headers["cookie"] = webBrowser.Document.Cookie;
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容 
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            if (!string.IsNullOrEmpty(result))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                Dictionary<string, object> dicone = js.Deserialize<Dictionary<string, object>>(result);
                foreach (string item in new string[] { "join", "manage", "create" })
                {
                    if (dicone != null && dicone.ContainsKey(item))
                    {
                        string jsone = js.Serialize(dicone[item]);
                        List<Dictionary<string, string>> dictwo = js.Deserialize<List<Dictionary<string, string>>>(jsone);
                        foreach (Dictionary<string, string> dicitem in dictwo)
                        {
                            if (dicitem.ContainsKey("gc") && dicitem.ContainsKey("gn"))
                            {
                                string gc = dicitem["gc"];
                                string gn = dicitem["gn"];
                                dicGroup.Add(gn + " (" + gc + ")", gc);
                                listGroup.Add(gn + " (" + gc + ")");
                            }
                        }
                    }
                }
            }
        }
        #endregion


        public static string getCreateQQ(WebBrowser webBrowser)
        {
            string cQQ = "";
            if (webBrowser.Document != null && webBrowser.Document.Cookie != null)
            {
                //获取已存在的cookie
               string cookie = webBrowser.Document.Cookie;
                //解析cookie
                string[] cookstr = cookie.Split(';');
            
                foreach (string str in cookstr)
                {
                    if (str.Trim().IndexOf("p_uin") == 0)
                    {
                        string[] cookieNameValue = str.Split('=');
                        if (!string.IsNullOrEmpty(cookieNameValue[1]))
                        {
                            cQQ = cookieNameValue[1];
                        }
                    }
                }
            }
            return cQQ;
        }
        #region 转换数据源类型
        public static List<SourceModel> getModelList(List<string> ltStr)
        {
            List<SourceModel> ltsm = new List<SourceModel>();
            foreach (string item in ltStr)
            {
                ltsm.Add(new SourceModel() { ShowName = item });
            }
            return ltsm;
        }
        #endregion
    }
}
