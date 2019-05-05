namespace Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.Port_s_TXT = new System.Windows.Forms.TextBox();
            this.openBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // Port_s_TXT
            // 
            this.Port_s_TXT.Location = new System.Drawing.Point(53, 13);
            this.Port_s_TXT.Name = "Port_s_TXT";
            this.Port_s_TXT.Size = new System.Drawing.Size(138, 20);
            this.Port_s_TXT.TabIndex = 1;
            // 
            // openBTN
            // 
            this.openBTN.Location = new System.Drawing.Point(53, 39);
            this.openBTN.Name = "openBTN";
            this.openBTN.Size = new System.Drawing.Size(138, 23);
            this.openBTN.TabIndex = 2;
            this.openBTN.Text = "Connect";
            this.openBTN.UseVisualStyleBackColor = true;
            this.openBTN.Click += new System.EventHandler(this.openBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 71);
            this.Controls.Add(this.openBTN);
            this.Controls.Add(this.Port_s_TXT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port_s_TXT;
        private System.Windows.Forms.Button openBTN;
    }
}

