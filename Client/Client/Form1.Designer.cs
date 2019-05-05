namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IpTXT = new System.Windows.Forms.TextBox();
            this.PortTXT = new System.Windows.Forms.TextBox();
            this.connectBTN = new System.Windows.Forms.Button();
            this.shareBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // IpTXT
            // 
            this.IpTXT.Location = new System.Drawing.Point(53, 12);
            this.IpTXT.Name = "IpTXT";
            this.IpTXT.Size = new System.Drawing.Size(187, 20);
            this.IpTXT.TabIndex = 2;
            // 
            // PortTXT
            // 
            this.PortTXT.Location = new System.Drawing.Point(53, 42);
            this.PortTXT.Name = "PortTXT";
            this.PortTXT.Size = new System.Drawing.Size(187, 20);
            this.PortTXT.TabIndex = 3;
            // 
            // connectBTN
            // 
            this.connectBTN.Location = new System.Drawing.Point(53, 68);
            this.connectBTN.Name = "connectBTN";
            this.connectBTN.Size = new System.Drawing.Size(75, 27);
            this.connectBTN.TabIndex = 4;
            this.connectBTN.Text = "connect";
            this.connectBTN.UseVisualStyleBackColor = true;
            this.connectBTN.Click += new System.EventHandler(this.connectBTN_Click);
            // 
            // shareBTN
            // 
            this.shareBTN.Location = new System.Drawing.Point(133, 68);
            this.shareBTN.Name = "shareBTN";
            this.shareBTN.Size = new System.Drawing.Size(106, 27);
            this.shareBTN.TabIndex = 6;
            this.shareBTN.Text = "share your screen";
            this.shareBTN.UseVisualStyleBackColor = true;
            this.shareBTN.Click += new System.EventHandler(this.shareBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 105);
            this.Controls.Add(this.shareBTN);
            this.Controls.Add(this.connectBTN);
            this.Controls.Add(this.PortTXT);
            this.Controls.Add(this.IpTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IpTXT;
        private System.Windows.Forms.TextBox PortTXT;
        private System.Windows.Forms.Button connectBTN;
        private System.Windows.Forms.Button shareBTN;
        private System.Windows.Forms.Timer timer1;
    }
}

