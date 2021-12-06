using BeanfunLogin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeanfunAccountCreator
{
    public partial class FormMain : Form
    {
        public ListViewItem lvi { set; get; }
        public string MulitUser;
        public BeanfunClient bfClient;

        public int nowNumber = 0;
        public int RestartNetworkAccountCount = 0;
        public class CreateAccountError
        {
            public int intResult;
            public string strOutstring;
        }

        public class CreateAccountResult
        {
            public int intResult;
            public string strOutstring;
            public AccountObject objResult;
        }

        public class AccountObject
        {
            public int service_account_sn;
            public string service_account_id;
            public string create_time;
            public int result;
            public string outstring;
            public string display_name;
        }

        public FormMain()
        {
            InitializeComponent();

            //interface 
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < nics.Length / 2; i++) cbNetworkName.Items.Add(nics[i].Name);
            cbNetworkName.SelectedIndex = 0;

            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
        }

        //網路重啟
        public void RestartNetwork(string name)
        {
            ProcessStartInfo psi;
            Process p = new Process();
            psi = new ProcessStartInfo("netsh", String.Format("interface set interface \"{0}\" disable", name));
            p.StartInfo = psi;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            Thread.Sleep(1000);
            psi = new ProcessStartInfo("netsh", String.Format("interface set interface \"{0}\" enable", name));
            p = new Process();
            p.StartInfo = psi;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAccount fa = new FormAccount(null);
                fa.Owner = this;
                fa.ShowDialog();

                string[] userLine = MulitUser.Split(new[] { Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);
                foreach (string user in userLine)
                {
                    string[] userData = user.Split(';');
                    ListViewItem _lvi = new ListViewItem();
                    _lvi.Text = userData[0];
                    _lvi.SubItems.Add(userData[1]);
                    _lvi.SubItems.Add("---");
                    _lvi.SubItems.Add("---");
                   lsvAccount.Items.Add(_lvi);
                }
              //  lsvAccount.Items.Add(lvi);
            }
            catch (Exception ex)
            { }

        }

        private void 編輯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lsvAccount.SelectedIndices[0];
                FormAccount fa = new FormAccount(lsvAccount.Items[index]);
                fa.Owner = this;
                fa.ShowDialog();
                lsvAccount.Items[index] = lvi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一組帳號");
            }
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lsvAccount.SelectedIndices[0];
                lsvAccount.Items[index].Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一組帳號");
            }
        }

        private void btnRestartNetwork_Click(object sender, EventArgs e)
        {
            RestartNetwork(cbNetworkName.SelectedItem.ToString());
        }

        private void btnRunSingle_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lsvAccount.SelectedIndices[0];
                this.bw.RunWorkerAsync(new string[] { lsvAccount.Items[index].Text, lsvAccount.Items[index].SubItems[1].Text, index.ToString() });
            }
            catch  (Exception ex)
            {
                MessageBox.Show("請選擇一組帳號");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                txtLog.Text += "--------------開始執行------------------\r\n";
                nowNumber = int.Parse(txtAccountNumber.Text);
                foreach (ListViewItem lvi in lsvAccount.Items)
                {
                    while (bw.IsBusy) Application.DoEvents();
                    this.bw.RunWorkerAsync(new string[] { lvi.Text, lvi.SubItems[1].Text, lvi.Index.ToString() });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("不得為空或是未知的錯誤");
            }
        }

        public bool testConnection()
        {
            try
            {
                IPAddress tIP = IPAddress.Parse("168.95.1.1");
                Ping tPingControl = new Ping();
                PingReply tReply = tPingControl.Send(tIP);
                tPingControl.Dispose();
                if (tReply.Status != IPStatus.Success)
                    return false;
                else
                    return true;
            }
            catch( Exception ex)
            {
                return false;
            }

        }
        

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!testConnection()) Thread.Sleep(100);
            string[] args = (string[])e.Argument;
            string[] obj = { createAccount(args[0], args[1]) , args[2]};
            e.Result = obj;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] result = (string[])e.Result;

            int index = int.Parse(result[1]);

            switch ( result[0] )
            {
                case "error":
                    lsvAccount.Items[index].SubItems[3].Text = "登入失敗";
                    txtLog.Text += String.Format("{0} : {1} {2}\r\n", DateTime.Now,lsvAccount.Items[index].Text, "登入失敗");
                    break;
                case "max":
                    lsvAccount.Items[index].SubItems[2].Text = "已認證";
                    lsvAccount.Items[index].SubItems[3].Text = "帳號數已達上限";
                    txtLog.Text += String.Format("{0} : {1} {2}\r\n", DateTime.Now, lsvAccount.Items[index].Text, "帳號數已達上限");
                    break;
                case "auth":
                    lsvAccount.Items[index].SubItems[2].Text = "未認證";
                    lsvAccount.Items[index].SubItems[3].Text = "未完成進階認證";
                    txtLog.Text += String.Format("{0} : {1} {2}\r\n", DateTime.Now, lsvAccount.Items[index].Text, "未完成進階認證");
                    break;
                default:
                    txtLog.Text += String.Format("{0} : {1} 成功{2}只 , 失敗{3}只\r\n", DateTime.Now, lsvAccount.Items[index].Text, result[0].Split(';')[0], result[0].Split(';')[1]);
                    lsvAccount.Items[index].SubItems[2].Text = "已認證";
                    lsvAccount.Items[index].SubItems[3].Text = "操作成功";
                    RestartNetworkAccountCount++;
                    break;
            }

            if ( index  == lsvAccount.Items.Count -1) txtLog.Text += "--------------執行完畢------------------\r\n";

            if ( (RestartNetworkAccountCount >= int.Parse(txtRestartNetworkAccountCount.Text)) && chkAutoRestartNetwork.Checked )
            {
                RestartNetwork(cbNetworkName.SelectedItem.ToString());
                RestartNetworkAccountCount = 0;
                txtLog.Text += String.Format("{0} : {1} \r\n", DateTime.Now,"網路重啟");
            }

            labNowNumber.Text = String.Format("*目前到 {0} 號", nowNumber);
        }

        public string createAccount(string username, string password)
        {
            BeanfunClient bf;
            bf = new BeanfunClient();
            bf.Login(username, password);
            if (bf.errmsg != null) return "error";
            if (bf.accountList.Count >= int.Parse(txtMaxAccountCount.Text)) return "max";

            int success = 0,
                fail = 0;
            for (int i = 1; i <= int.Parse(txtMaxAccountCount.Text) - bf.accountList.Count;i++)
            {
                string accountName = txtAccountPrefix.Text;
                accountName += nowNumber;
                string response = bf.CreateAccount(accountName);
                try
                {
                    CreateAccountResult createResult = JsonConvert.DeserializeObject<CreateAccountResult>(response);
                    nowNumber++;
                    success++;
                }
                catch (Exception ex)
                {
                    CreateAccountError err = JsonConvert.DeserializeObject<CreateAccountError>(response);
                    if (err.strOutstring.IndexOf("進階認證") >= 0) return "auth";
                    fail++;
                }
            }
            return success.ToString() + ";" + fail.ToString();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lsvAccount.Items.Clear();
        }
    }
}
