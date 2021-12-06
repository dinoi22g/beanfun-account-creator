using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Web;

namespace BeanfunLogin
{
    public partial class BeanfunClient : WebClient
    {

        private string RegularLogin(string id, string pass, string skey)
        {
            try
            {
                string response = this.DownloadString("https://tw.newlogin.beanfun.com/login/id-pass_form.aspx?skey=" + skey);
                Regex regex = new Regex("id=\"__VIEWSTATE\" value=\"(.*)\" />");
                if (!regex.IsMatch(response))
                    {this.errmsg = "LoginNoViewstate"; return null;}
                string viewstate = regex.Match(response).Groups[1].Value;

                regex = new Regex("id=\"__EVENTVALIDATION\" value=\"(.*)\" />");
                if (!regex.IsMatch(response))
                    { this.errmsg = "LoginNoEventvalidation"; return null; }
                string eventvalidation = regex.Match(response).Groups[1].Value;
                regex = new Regex("id=\"__VIEWSTATEGENERATOR\" value=\"(.*)\" />");
                if (!regex.IsMatch(response))
                { this.errmsg = "LoginNoViewstateGenerator"; return null; }
                string viewstateGenerator = regex.Match(response).Groups[1].Value;
                regex = new Regex("id=\"LBD_VCID_c_login_idpass_form_samplecaptcha\" value=\"(.*)\" />");
                if (!regex.IsMatch(response))
                { this.errmsg = "LoginNoSamplecaptcha"; return null; }
                string samplecaptcha = regex.Match(response).Groups[1].Value;

                NameValueCollection payload = new NameValueCollection();
                payload.Add("__EVENTTARGET", "");
                payload.Add("__EVENTARGUMENT", "");
                payload.Add("__VIEWSTATE", viewstate);
                payload.Add("__VIEWSTATEGENERATOR", viewstateGenerator);
                payload.Add("__EVENTVALIDATION", eventvalidation);
                payload.Add("t_AccountID", id);
                payload.Add("t_Password", pass);
                payload.Add("CodeTextBox", "");
                payload.Add("btn_login", "登入");
                payload.Add("LBD_VCID_c_login_idpass_form_samplecaptcha", samplecaptcha);

                response = Encoding.UTF8.GetString(this.UploadValues("https://tw.newlogin.beanfun.com/login/id-pass_form.aspx?skey=" + skey, payload));

                regex = new Regex("akey=(.*)");
                if (!regex.IsMatch(this.ResponseUri.ToString()))
                { this.errmsg = "帳號或密碼錯誤"; return null; }
                string akey = regex.Match(this.ResponseUri.ToString()).Groups[1].Value;

                return akey;
            }
            catch (Exception e)
            {
                this.errmsg = "未知的錯誤\n\n" + e.Message + "\n" + e.StackTrace;
                return null;
            }
        }

        private bool vaktenAuthenticate(string lblSID)
        {
            try
            {
                string[] ports = { "14057", "16057", "17057" };
                foreach (string port in ports)
                {
                    string response = this.DownloadString("https://vaktenlocal.com:" + port + "/api/2/authenticate.jsonp?customerId=GAMANIA&sessionId=" + lblSID + "&api=https://api.keypascoid.com/Rest/ApiService/3&callback=_jqjsp&alt=json-in-script");
                    if (response == "_jqjsp( {\"statusCode\":200} );")
                    {
                        //response = this.DownloadString("https://localhost:" + port + "/api/1/aut.jsonp?sid=GAMANIA" + lblSID + "&api=YXBpLmtleXBhc2NvaWQuY29tOjQ0My9SZXN0L0FwaVNlcnZpY2Uv&callback=_jqjsp&alt=json-in-script");
                        //if (response == "_jqjsp( {\"statusCode\":200} );") return true;
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        
       
        public string GetSessionkey()
        {
            string response = this.DownloadString("https://tw.beanfun.com/beanfun_block/bflogin/default.aspx?service=999999_T0");
            //this.DownloadString(this.ResponseHeaders["Location"]);
            //this.DownloadString(this.ResponseHeaders["Location"]);
            //response = this.ResponseHeaders["Location"];
            response = this.ResponseUri.ToString();
            if (response == null)
            { this.errmsg = "LoginNoResponse"; return null; }
            Regex regex = new Regex("skey=(.*)&display");
            if (!regex.IsMatch(response))
            { this.errmsg = "LoginNoSkey"; return null; }
            return regex.Match(response).Groups[1].Value;
        }

        public void Login(string id, string pass, string service_code = "610074", string service_region = "T9")
        {
            this.webtoken = null;
            try
            {
                string response = null;
                string skey = null;
                string akey = null;
                skey = GetSessionkey();
                akey = RegularLogin(id, pass, skey);
                if (akey == null)
                    return;

                NameValueCollection payload = new NameValueCollection();
                payload.Add("SessionKey", skey);
                payload.Add("AuthKey", akey);
                Debug.WriteLine(skey);
                Debug.WriteLine(akey);
                response = Encoding.UTF8.GetString(this.UploadValues("https://tw.beanfun.com/beanfun_block/bflogin/return.aspx", payload));
                Debug.WriteLine(response);
                response = this.DownloadString("https://tw.beanfun.com/" + this.ResponseHeaders["Location"]);
                Debug.WriteLine(response);
                Debug.WriteLine(this.ResponseHeaders);

                this.webtoken = this.GetCookie("bfWebToken");
                if (this.webtoken == "")
                { this.errmsg = "LoginNoWebtoken"; return; }

                GetAccounts(service_code, service_region, false);
            }
            catch (Exception e)
            {
                if (e is WebException)
                {
                    this.errmsg = "網路連線錯誤，請檢查官方網站連線是否正常。" + e.Message;
                }
                else
                {
                    this.errmsg = "LoginUnknown\n\n" + e.Message + "\n" + e.StackTrace;
                }
                return;
            }
        }

    }
}
