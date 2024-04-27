namespace MSG
{
    partial class HowToPlayForm
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
            lblHowToPlay = new Label();
            SuspendLayout();
            // 
            // lblHowToPlay
            // 
            lblHowToPlay.AutoSize = true;
            lblHowToPlay.Location = new Point(211, 139);
            lblHowToPlay.Name = "lblHowToPlay";
            lblHowToPlay.Size = new Size(306, 15);
            lblHowToPlay.TabIndex = 0;
            lblHowToPlay.Text = "아~~~ 이게 2시간 만에 만든게 맞냐 가슴이 웅장해진다";
            // 
            // HowToPlayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHowToPlay);
            Name = "HowToPlayForm";
            Text = "HowToPlayForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHowToPlay;
    }
}