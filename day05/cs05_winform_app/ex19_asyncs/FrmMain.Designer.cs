namespace ex19_asyncs
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            PrgCopy = new ProgressBar();
            BtnCancel = new Button();
            BtnAstncCopy = new Button();
            BtnSyncCopy = new Button();
            BtnSetTarget = new Button();
            BtnGetSource = new Button();
            TxtTarget = new TextBox();
            TxtSource = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "소스 :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PrgCopy);
            groupBox1.Controls.Add(BtnCancel);
            groupBox1.Controls.Add(BtnAstncCopy);
            groupBox1.Controls.Add(BtnSyncCopy);
            groupBox1.Controls.Add(BtnSetTarget);
            groupBox1.Controls.Add(BtnGetSource);
            groupBox1.Controls.Add(TxtTarget);
            groupBox1.Controls.Add(TxtSource);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 163);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "비동기 전송";
            // 
            // PrgCopy
            // 
            PrgCopy.Location = new Point(6, 128);
            PrgCopy.Name = "PrgCopy";
            PrgCopy.Size = new Size(319, 23);
            PrgCopy.TabIndex = 3;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(244, 81);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(81, 41);
            BtnCancel.TabIndex = 2;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnAstncCopy
            // 
            BtnAstncCopy.Location = new Point(116, 81);
            BtnAstncCopy.Name = "BtnAstncCopy";
            BtnAstncCopy.Size = new Size(122, 41);
            BtnAstncCopy.TabIndex = 2;
            BtnAstncCopy.Text = "비동기화 복사";
            BtnAstncCopy.UseVisualStyleBackColor = true;
            BtnAstncCopy.Click += BtnAstncCopy_Click;
            // 
            // BtnSyncCopy
            // 
            BtnSyncCopy.Location = new Point(6, 81);
            BtnSyncCopy.Name = "BtnSyncCopy";
            BtnSyncCopy.Size = new Size(104, 41);
            BtnSyncCopy.TabIndex = 2;
            BtnSyncCopy.Text = "동기화 복사";
            BtnSyncCopy.UseVisualStyleBackColor = true;
            BtnSyncCopy.Click += BtnSyncCopy_Click;
            // 
            // BtnSetTarget
            // 
            BtnSetTarget.Location = new Point(298, 51);
            BtnSetTarget.Name = "BtnSetTarget";
            BtnSetTarget.Size = new Size(27, 23);
            BtnSetTarget.TabIndex = 2;
            BtnSetTarget.Text = "...";
            BtnSetTarget.UseVisualStyleBackColor = true;
            BtnSetTarget.Click += BtnSetTarget_Click;
            // 
            // BtnGetSource
            // 
            BtnGetSource.Location = new Point(298, 15);
            BtnGetSource.Name = "BtnGetSource";
            BtnGetSource.Size = new Size(27, 23);
            BtnGetSource.TabIndex = 2;
            BtnGetSource.Text = "...";
            BtnGetSource.UseVisualStyleBackColor = true;
            BtnGetSource.Click += BtnGetSource_Click;
            // 
            // TxtTarget
            // 
            TxtTarget.Location = new Point(50, 52);
            TxtTarget.Name = "TxtTarget";
            TxtTarget.ReadOnly = true;
            TxtTarget.Size = new Size(242, 23);
            TxtTarget.TabIndex = 1;
            // 
            // TxtSource
            // 
            TxtSource.Location = new Point(50, 16);
            TxtSource.Name = "TxtSource";
            TxtSource.Size = new Size(242, 23);
            TxtSource.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 55);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "타겟 :";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 187);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "비동기 파일복사";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ProgressBar PrgCopy;
        private Button BtnCancel;
        private Button BtnAstncCopy;
        private Button BtnSyncCopy;
        private Button BtnSetTarget;
        private Button BtnGetSource;
        private TextBox TxtTarget;
        private TextBox TxtSource;
        private Label label2;
    }
}
