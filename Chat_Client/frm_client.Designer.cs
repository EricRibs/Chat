namespace Chat_Client
{
    partial class frm_client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_c1_ip = new System.Windows.Forms.TextBox();
            this.txb_c1_p = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_c2_ip = new System.Windows.Forms.TextBox();
            this.txb_c2_p = new System.Windows.Forms.TextBox();
            this.Lst_msg = new System.Windows.Forms.ListBox();
            this.txb_msg = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_c1_ip);
            this.groupBox1.Controls.Add(this.txb_c1_p);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // txb_c1_ip
            // 
            this.txb_c1_ip.Location = new System.Drawing.Point(94, 19);
            this.txb_c1_ip.Name = "txb_c1_ip";
            this.txb_c1_ip.Size = new System.Drawing.Size(100, 20);
            this.txb_c1_ip.TabIndex = 1;
            // 
            // txb_c1_p
            // 
            this.txb_c1_p.Location = new System.Drawing.Point(124, 56);
            this.txb_c1_p.Name = "txb_c1_p";
            this.txb_c1_p.Size = new System.Drawing.Size(70, 20);
            this.txb_c1_p.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_c2_ip);
            this.groupBox2.Controls.Add(this.txb_c2_p);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP";
            // 
            // txb_c2_ip
            // 
            this.txb_c2_ip.Location = new System.Drawing.Point(94, 19);
            this.txb_c2_ip.Name = "txb_c2_ip";
            this.txb_c2_ip.Size = new System.Drawing.Size(100, 20);
            this.txb_c2_ip.TabIndex = 1;
            // 
            // txb_c2_p
            // 
            this.txb_c2_p.Location = new System.Drawing.Point(124, 56);
            this.txb_c2_p.Name = "txb_c2_p";
            this.txb_c2_p.Size = new System.Drawing.Size(70, 20);
            this.txb_c2_p.TabIndex = 2;
            // 
            // Lst_msg
            // 
            this.Lst_msg.FormattingEnabled = true;
            this.Lst_msg.Location = new System.Drawing.Point(21, 146);
            this.Lst_msg.Name = "Lst_msg";
            this.Lst_msg.Size = new System.Drawing.Size(464, 95);
            this.Lst_msg.TabIndex = 1;
            // 
            // txb_msg
            // 
            this.txb_msg.Location = new System.Drawing.Point(21, 250);
            this.txb_msg.Name = "txb_msg";
            this.txb_msg.Size = new System.Drawing.Size(383, 20);
            this.txb_msg.TabIndex = 2;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(410, 117);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_send
            // 
            this.Btn_send.Location = new System.Drawing.Point(410, 247);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(75, 23);
            this.Btn_send.TabIndex = 3;
            this.Btn_send.Text = "Send";
            this.Btn_send.UseVisualStyleBackColor = true;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // frm_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 294);
            this.Controls.Add(this.Btn_send);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.txb_msg);
            this.Controls.Add(this.Lst_msg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_client";
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_c1_ip;
        private System.Windows.Forms.TextBox txb_c1_p;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_c2_ip;
        private System.Windows.Forms.TextBox txb_c2_p;
        private System.Windows.Forms.ListBox Lst_msg;
        private System.Windows.Forms.TextBox txb_msg;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_send;
    }
}

