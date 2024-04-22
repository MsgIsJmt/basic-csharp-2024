namespace BookRentalShopApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            MnsBookRental = new MenuStrip();
            dToolStripMenuItem = new ToolStripMenuItem();
            dToolStripMenuItem1 = new ToolStripMenuItem();
            dToolStripMenuItem2 = new ToolStripMenuItem();
            StsBookRental = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            MnsBookRental.SuspendLayout();
            StsBookRental.SuspendLayout();
            SuspendLayout();
            // 
            // MnsBookRental
            // 
            MnsBookRental.Items.AddRange(new ToolStripItem[] { dToolStripMenuItem, dToolStripMenuItem1, dToolStripMenuItem2 });
            MnsBookRental.Location = new Point(0, 0);
            MnsBookRental.Name = "MnsBookRental";
            MnsBookRental.Size = new Size(800, 24);
            MnsBookRental.TabIndex = 1;
            MnsBookRental.Text = "menuStrip1";
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(57, 20);
            dToolStripMenuItem.Text = "파일(&F)";
            // 
            // dToolStripMenuItem1
            // 
            dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            dToolStripMenuItem1.Size = new Size(62, 20);
            dToolStripMenuItem1.Text = "관리(&M)";
            // 
            // dToolStripMenuItem2
            // 
            dToolStripMenuItem2.Name = "dToolStripMenuItem2";
            dToolStripMenuItem2.Size = new Size(72, 20);
            dToolStripMenuItem2.Text = "도움말(&H)";
            // 
            // StsBookRental
            // 
            StsBookRental.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            StsBookRental.Location = new Point(0, 428);
            StsBookRental.Name = "StsBookRental";
            StsBookRental.Size = new Size(800, 22);
            StsBookRental.TabIndex = 2;
            StsBookRental.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(83, 17);
            toolStripStatusLabel1.Text = "로그인 아이디";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(40, 17);
            toolStripStatusLabel2.Text = "UserId";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(109, 17);
            toolStripStatusLabel3.Text = "LastLoginDateTime";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StsBookRental);
            Controls.Add(MnsBookRental);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MnsBookRental;
            Name = "FrmMain";
            Text = "책 대여점 v1.1";
            Load += FrmMain_Load;
            MnsBookRental.ResumeLayout(false);
            MnsBookRental.PerformLayout();
            StsBookRental.ResumeLayout(false);
            StsBookRental.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MnsBookRental;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem1;
        private ToolStripMenuItem dToolStripMenuItem2;
        private StatusStrip StsBookRental;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}
