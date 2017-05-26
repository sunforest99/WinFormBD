namespace BdBoss
{
    partial class Form2
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
            this.StackList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // StackList
            // 
            this.StackList.FormattingEnabled = true;
            this.StackList.ItemHeight = 12;
            this.StackList.Location = new System.Drawing.Point(12, 12);
            this.StackList.Name = "StackList";
            this.StackList.Size = new System.Drawing.Size(410, 232);
            this.StackList.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.StackList);
            this.Name = "Form2";
            this.Text = "강화 스택";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StackList;
    }
}