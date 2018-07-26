using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace NetConfiguration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Tag != null && !(bool)btnOk.Tag)
            {
                return;
            }

            Process proc = new Process();
            proc.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            proc.StartInfo.FileName = "IP.bat";
            proc.StartInfo.Arguments = $"{txtIP.Text} {txtGateway.Text} {txtDNS.Text} {txtDNSBak.Text}";
            proc.Start();
            proc.WaitForExit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIP.Text = string.Empty;
            txtGateway.Text = string.Empty;
            txtDNS.Text = string.Empty;
            txtDNSBak.Text = string.Empty;
            lblMsgIP.Text = string.Empty;
            lblMsgGateway.Text = string.Empty;
            lblMsgDNS.Text = string.Empty;
            lblMsgDNSBak.Text = string.Empty;
            btnOk.Tag = null;
        }

        private void txtIP_Leave(object sender, EventArgs e)
        {
            var txtbox = sender as TextBox;
            btnOk.Tag = this.Validate(txtbox, lblMsgIP);
        }

        private void txtGateway_Leave(object sender, EventArgs e)
        {
            var txtbox = sender as TextBox;
            btnOk.Tag = this.Validate(txtbox, lblMsgGateway);
        }

        private void txtDNS_Leave(object sender, EventArgs e)
        {
            var txtbox = sender as TextBox;
            btnOk.Tag = this.Validate(txtbox, lblMsgDNS);
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            var txtbox = sender as TextBox;
            btnOk.Tag = this.Validate(txtbox, lblMsgDNSBak);
        }

        private bool Validate(TextBox textBox, Label msgLabel)
        {
            Regex regex = new Regex(@"^(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?))$");
            string formatMsg = "请输入正确的格式，\n例如：192.168.1.1";
            if (!string.IsNullOrWhiteSpace(textBox.Text) && !regex.IsMatch(textBox.Text))
            {
                msgLabel.Text = formatMsg;
                return false;
            }
            else
            {
                msgLabel.Text = string.Empty;
                return true;
            }
        }
    }
}
