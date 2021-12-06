using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeanfunLogin
{
    partial class BeanfunClient
    {
        public void GetAccounts(string service_code, string service_region, bool fatal = true)
        {
            if (this.webtoken == null)  { return; }

            Regex regex;
            string response;
    
            response = this.DownloadString("https://tw.beanfun.com/beanfun_block/auth.aspx?channel=game_zone&page_and_query=game_start.aspx%3Fservice_code_and_region%3D" + service_code + "_" + service_region + "&web_token=" + webtoken, Encoding.UTF8);

            // Add account list to ListView.
            regex = new Regex("<div id=\"(\\w+)\" sn=\"(\\d+)\" name=\"([^\"]+)\"");
            this.accountList.Clear();
            foreach (Match match in regex.Matches(response))
            {
                if (match.Groups[1].Value == "" || match.Groups[2].Value == "" || match.Groups[3].Value == "")
                { continue; }
                accountList.Add(new AccountList(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value));
            }
            if (fatal && accountList.Count == 0)
            { this.errmsg = "LoginNoAccount"; return; }

            this.errmsg = null;
        }

        public string CreateAccount(string account_name)
        {
            NameValueCollection payload = new NameValueCollection();
            payload.Add("strFunction", "AddServiceAccount");
            payload.Add("npsc", "");
            payload.Add("npsr", "");
            payload.Add("sc", "610074");
            payload.Add("sr", "T9");
            payload.Add("sadn", account_name);
            payload.Add("sag", "");
            string response = Encoding.UTF8.GetString(this.UploadValues("https://tw.beanfun.com/generic_handlers/gamezone.ashx", payload));
            return response;
        }
    }
}
