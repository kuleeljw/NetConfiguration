namespace NetConfiguration
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNS = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtDNSBak = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMsgIP = new System.Windows.Forms.Label();
            this.lblMsgGateway = new System.Windows.Forms.Label();
            this.lblMsgDNS = new System.Windows.Forms.Label();
            this.lblMsgDNSBak = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(63, 404);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入IP地址";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(63, 53);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(211, 25);
            this.txtIP.TabIndex = 2;
            this.txtIP.Leave += new System.EventHandler(this.txtIP_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入网关地址";
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(63, 141);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(211, 25);
            this.txtGateway.TabIndex = 4;
            this.txtGateway.Leave += new System.EventHandler(this.txtGateway_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "请输入主dns地址";
            // 
            // txtDNS
            // 
            this.txtDNS.Location = new System.Drawing.Point(63, 231);
            this.txtDNS.Name = "txtDNS";
            this.txtDNS.Size = new System.Drawing.Size(211, 25);
            this.txtDNS.TabIndex = 6;
            this.txtDNS.Leave += new System.EventHandler(this.txtDNS_Leave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 310);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(136, 15);
            this.label.TabIndex = 7;
            this.label.Text = "请输入备份dns地址";
            // 
            // txtDNSBak
            // 
            this.txtDNSBak.Location = new System.Drawing.Point(63, 328);
            this.txtDNSBak.Name = "txtDNSBak";
            this.txtDNSBak.Size = new System.Drawing.Size(211, 25);
            this.txtDNSBak.TabIndex = 8;
            this.txtDNSBak.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(199, 404);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMsgIP
            // 
            this.lblMsgIP.AutoSize = true;
            this.lblMsgIP.ForeColor = System.Drawing.Color.Red;
            this.lblMsgIP.Location = new System.Drawing.Point(60, 81);
            this.lblMsgIP.Name = "lblMsgIP";
            this.lblMsgIP.Size = new System.Drawing.Size(0, 15);
            this.lblMsgIP.TabIndex = 1;
            // 
            // lblMsgGateway
            // 
            this.lblMsgGateway.AutoSize = true;
            this.lblMsgGateway.ForeColor = System.Drawing.Color.Red;
            this.lblMsgGateway.Location = new System.Drawing.Point(60, 169);
            this.lblMsgGateway.Name = "lblMsgGateway";
            this.lblMsgGateway.Size = new System.Drawing.Size(0, 15);
            this.lblMsgGateway.TabIndex = 3;
            // 
            // lblMsgDNS
            // 
            this.lblMsgDNS.AutoSize = true;
            this.lblMsgDNS.ForeColor = System.Drawing.Color.Red;
            this.lblMsgDNS.Location = new System.Drawing.Point(60, 259);
            this.lblMsgDNS.Name = "lblMsgDNS";
            this.lblMsgDNS.Size = new System.Drawing.Size(0, 15);
            this.lblMsgDNS.TabIndex = 5;
            // 
            // lblMsgDNSBak
            // 
            this.lblMsgDNSBak.AutoSize = true;
            this.lblMsgDNSBak.ForeColor = System.Drawing.Color.Red;
            this.lblMsgDNSBak.Location = new System.Drawing.Point(60, 356);
            this.lblMsgDNSBak.Name = "lblMsgDNSBak";
            this.lblMsgDNSBak.Size = new System.Drawing.Size(0, 15);
            this.lblMsgDNSBak.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(196, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtDNSBak);
            this.Controls.Add(this.lblMsgDNSBak);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtDNS);
            this.Controls.Add(this.lblMsgDNS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.lblMsgGateway);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblMsgIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "网络配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNS;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtDNSBak;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMsgIP;
        private System.Windows.Forms.Label lblMsgGateway;
        private System.Windows.Forms.Label lblMsgDNS;
        private System.Windows.Forms.Label lblMsgDNSBak;
        private System.Windows.Forms.Label label9;
    }
}

