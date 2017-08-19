namespace BdBoss
{
    partial class Form4
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
            this.Address = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.Move = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(60, 84);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(300, 21);
            this.Address.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Window;
            this.label.Location = new System.Drawing.Point(16, 87);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 12);
            this.label.TabIndex = 2;
            this.label.Text = "주소";
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(366, 82);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(75, 23);
            this.Move.TabIndex = 3;
            this.Move.Text = "이동";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.MoveBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 111);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(754, 411);
            this.webBrowser.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 533);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Address);
            this.Name = "Form4";
            this.Text = "Web Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}