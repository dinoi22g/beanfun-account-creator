using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeanfunAccountCreator
{
    public partial class FormAccount : Form
    {
        ListViewItem lvi;
        public FormAccount(ListViewItem _lvi)
        {
            InitializeComponent();
            lvi = new ListViewItem();
            if ( _lvi != null )
            {
                txtUsername.Text = _lvi.Text;
                txtPassword.Text = _lvi.SubItems[1].Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ( txtMulitUser.TextLength == 0 ) MessageBox.Show("請輸入至少一組帳號");
            else
            {
                FormMain fm = (FormMain)this.Owner;
                fm.MulitUser = txtMulitUser.Text;
                this.Close();
            }
            /*if ( txtUsername.TextLength == 0 || txtPassword.TextLength == 0) MessageBox.Show("請輸入帳號及密碼");
            else
            {
                lvi.Text = txtUsername.Text;
                lvi.SubItems.Add(txtPassword.Text);
                lvi.SubItems.Add("---");
                lvi.SubItems.Add("---");

                FormMain fm = (FormMain)this.Owner;
                fm.lvi = lvi;
                this.Close();
            }*/
        }
    }
}
