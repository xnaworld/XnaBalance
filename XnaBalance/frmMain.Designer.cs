namespace XnaBalance
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabPage1 = new TabPage();
            llAccountBalance = new LinkLabel();
            label3 = new Label();
            llCheck = new LinkLabel();
            txtBalance = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            txtPort = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtIP = new TextBox();
            label7 = new Label();
            txtAccountBalance = new TextBox();
            label8 = new Label();
            tabMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPage1);
            tabMain.Controls.Add(tabPage2);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(800, 283);
            tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtAccountBalance);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(llAccountBalance);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(llCheck);
            tabPage1.Controls.Add(txtBalance);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 253);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Balance";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // llAccountBalance
            // 
            llAccountBalance.AutoSize = true;
            llAccountBalance.Location = new Point(513, 88);
            llAccountBalance.Name = "llAccountBalance";
            llAccountBalance.Size = new Size(103, 17);
            llAccountBalance.TabIndex = 11;
            llAccountBalance.TabStop = true;
            llAccountBalance.Text = "Account Balance";
            llAccountBalance.LinkClicked += llAccountBalance_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 58);
            label3.Name = "label3";
            label3.Size = new Size(30, 17);
            label3.TabIndex = 10;
            label3.Text = "Xna";
            // 
            // llCheck
            // 
            llCheck.AutoSize = true;
            llCheck.Location = new Point(513, 55);
            llCheck.Name = "llCheck";
            llCheck.Size = new Size(118, 17);
            llCheck.TabIndex = 8;
            llCheck.TabStop = true;
            llCheck.Text = "Check Xna Balance";
            llCheck.LinkClicked += llCheck_LinkClicked;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(149, 52);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(186, 23);
            txtBalance.TabIndex = 9;
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 7;
            label2.Text = "Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 6;
            label1.Text = "Xna Address：";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(149, 20);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(496, 23);
            txtAddress.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtPort);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtIP);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 253);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 236);
            label4.Name = "label4";
            label4.Size = new Size(352, 17);
            label4.TabIndex = 15;
            label4.Text = "Donate address: NRotnt453Yzsq9ibiVfC661YQCWnA2oGN3";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(162, 46);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(186, 23);
            txtPort.TabIndex = 14;
            txtPort.Text = "19001";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 46);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 13;
            label5.Text = "Port:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 20);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 12;
            label6.Text = "Xna Net IP(host):";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(162, 17);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(360, 23);
            txtIP.TabIndex = 11;
            txtIP.Text = "localhost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 94);
            label7.Name = "label7";
            label7.Size = new Size(30, 17);
            label7.TabIndex = 14;
            label7.Text = "Xna";
            // 
            // txtAccountBalance
            // 
            txtAccountBalance.Location = new Point(149, 88);
            txtAccountBalance.Name = "txtAccountBalance";
            txtAccountBalance.ReadOnly = true;
            txtAccountBalance.Size = new Size(186, 23);
            txtAccountBalance.TabIndex = 13;
            txtAccountBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 91);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 12;
            label8.Text = "Account Balance:";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 283);
            Controls.Add(tabMain);
            Name = "frmMain";
            Text = "Xna Balance Check V0.1";
            tabMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private LinkLabel llCheck;
        private TextBox txtBalance;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtPort;
        private Label label5;
        private Label label6;
        private TextBox txtIP;
        private Label label4;
        private LinkLabel llAccountBalance;
        private Label label7;
        private TextBox txtAccountBalance;
        private Label label8;
    }
}