namespace BdBoss
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Nbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RealTime = new System.Windows.Forms.Label();
            this.NSpawnTime = new System.Windows.Forms.Label();
            this.WindowSet = new System.Windows.Forms.Button();
            this.Stack = new System.Windows.Forms.Button();
            this.Media = new System.Windows.Forms.Button();
            this.WebPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nbtn
            // 
            this.Nbtn.Location = new System.Drawing.Point(136, 119);
            this.Nbtn.Name = "Nbtn";
            this.Nbtn.Size = new System.Drawing.Size(75, 23);
            this.Nbtn.TabIndex = 0;
            this.Nbtn.Text = "누아앙";
            this.Nbtn.Click += new System.EventHandler(this.Nbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RealTime
            // 
            this.RealTime.AutoSize = true;
            this.RealTime.Font = new System.Drawing.Font("Gulim", 14F);
            this.RealTime.Location = new System.Drawing.Point(34, 38);
            this.RealTime.Name = "RealTime";
            this.RealTime.Size = new System.Drawing.Size(85, 19);
            this.RealTime.TabIndex = 1;
            this.RealTime.Text = "현재시간";
            // 
            // NSpawnTime
            // 
            this.NSpawnTime.AutoSize = true;
            this.NSpawnTime.Font = new System.Drawing.Font("Gulim", 14F);
            this.NSpawnTime.Location = new System.Drawing.Point(34, 82);
            this.NSpawnTime.Name = "NSpawnTime";
            this.NSpawnTime.Size = new System.Drawing.Size(129, 19);
            this.NSpawnTime.TabIndex = 2;
            this.NSpawnTime.Text = "누베르 젠타임";
            // 
            // WindowSet
            // 
            this.WindowSet.Location = new System.Drawing.Point(4, 12);
            this.WindowSet.Name = "WindowSet";
            this.WindowSet.Size = new System.Drawing.Size(96, 23);
            this.WindowSet.TabIndex = 4;
            this.WindowSet.Text = "창 맨위로";
            this.WindowSet.UseVisualStyleBackColor = true;
            this.WindowSet.Click += new System.EventHandler(this.WindowSetBtn_Click);
            // 
            // Stack
            // 
            this.Stack.Location = new System.Drawing.Point(278, 12);
            this.Stack.Name = "Stack";
            this.Stack.Size = new System.Drawing.Size(75, 23);
            this.Stack.TabIndex = 5;
            this.Stack.Text = "강화 스택";
            this.Stack.UseVisualStyleBackColor = true;
            this.Stack.Click += new System.EventHandler(this.StackBtn_Click);
            // 
            // Media
            // 
            this.Media.Location = new System.Drawing.Point(106, 12);
            this.Media.Name = "Media";
            this.Media.Size = new System.Drawing.Size(85, 23);
            this.Media.TabIndex = 6;
            this.Media.Text = "영상";
            this.Media.UseVisualStyleBackColor = true;
            this.Media.Click += new System.EventHandler(this.MediaBtn_Click);
            // 
            // WebPlayer
            // 
            this.WebPlayer.Location = new System.Drawing.Point(197, 12);
            this.WebPlayer.Name = "WebPlayer";
            this.WebPlayer.Size = new System.Drawing.Size(75, 23);
            this.WebPlayer.TabIndex = 7;
            this.WebPlayer.Text = "웹";
            this.WebPlayer.UseVisualStyleBackColor = true;
            this.WebPlayer.Click += new System.EventHandler(this.WebPlayerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(136, 241);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 9;
            this.Refresh.Text = "새로고침";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 276);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebPlayer);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.Stack);
            this.Controls.Add(this.WindowSet);
            this.Controls.Add(this.NSpawnTime);
            this.Controls.Add(this.RealTime);
            this.Controls.Add(this.Nbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "보스 젠타임";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label RealTime;
        private System.Windows.Forms.Label NSpawnTime;
        private System.Windows.Forms.Button WindowSet;
        private System.Windows.Forms.Button Stack;
        private System.Windows.Forms.Button Media;
        private System.Windows.Forms.Button WebPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Refresh;
    }
}

