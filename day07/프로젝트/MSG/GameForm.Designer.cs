namespace MSG
{
    partial class GameForm
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
            msg = new Label();
            txtInput = new TextBox();
            btnOK = new Button();
            lblMessage = new Label();
            lblLives = new Label();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // msg
            // 
            msg.AutoSize = true;
            msg.Location = new Point(12, 9);
            msg.Name = "msg";
            msg.Size = new Size(30, 15);
            msg.TabIndex = 0;
            msg.Text = "msg";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(69, 182);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(692, 50);
            txtInput.TabIndex = 1;
            txtInput.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOK.Location = new Point(444, 322);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(153, 63);
            btnOK.TabIndex = 2;
            btnOK.Text = "확인";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("맑은 고딕", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblMessage.Location = new Point(69, 87);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(479, 45);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "                 숫자 맞추기 게임";
            lblMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblLives.Location = new Point(617, 34);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(34, 30);
            lblLives.TabIndex = 6;
            lblLives.Text = "★";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblResult.Location = new Point(69, 132);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 32);
            lblResult.TabIndex = 7;
            lblResult.Text = "♠";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(158, 66);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 8;
            label1.Text = "☆";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(685, 283);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 8;
            label2.Text = "☆";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(69, 394);
            label3.Name = "label3";
            label3.Size = new Size(26, 21);
            label3.TabIndex = 8;
            label3.Text = "☆";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(94, 23);
            label4.Name = "label4";
            label4.Size = new Size(26, 21);
            label4.TabIndex = 8;
            label4.Text = "☆";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label5.Location = new Point(323, 271);
            label5.Name = "label5";
            label5.Size = new Size(26, 21);
            label5.TabIndex = 8;
            label5.Text = "☆";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label6.Location = new Point(522, 23);
            label6.Name = "label6";
            label6.Size = new Size(26, 21);
            label6.TabIndex = 8;
            label6.Text = "☆";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label7.Location = new Point(694, 123);
            label7.Name = "label7";
            label7.Size = new Size(26, 21);
            label7.TabIndex = 8;
            label7.Text = "☆";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label8.Location = new Point(217, 30);
            label8.Name = "label8";
            label8.Size = new Size(26, 21);
            label8.TabIndex = 8;
            label8.Text = "☆";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label9.Location = new Point(753, 87);
            label9.Name = "label9";
            label9.Size = new Size(26, 21);
            label9.TabIndex = 8;
            label9.Text = "☆";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("맑은 고딕", 18F);
            btnStart.Location = new Point(158, 322);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(153, 63);
            btnStart.TabIndex = 9;
            btnStart.Text = "게임 시작";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(lblLives);
            Controls.Add(lblMessage);
            Controls.Add(btnOK);
            Controls.Add(txtInput);
            Controls.Add(msg);
            Name = "GameForm";
            Text = "숫자 맞추기 게임";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label msg;
        private TextBox txtInput;
        private Button btnOK;
        private Label lblMessage;
        private Label lblLives;
        private Label lblResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnStart;
    }
}

