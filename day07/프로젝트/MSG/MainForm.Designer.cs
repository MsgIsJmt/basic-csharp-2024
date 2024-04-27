namespace MSG
{
    partial class MainForm
    {
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnViewRecords;

        private void InitializeComponent()
        {
            btnStartGame = new Button();
            btnViewRecords = new Button();
            btnHow = new Button();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(112, 324);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(150, 30);
            btnStartGame.TabIndex = 1;
            btnStartGame.Text = "게임 시작";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnViewRecords
            // 
            btnViewRecords.Location = new Point(599, 324);
            btnViewRecords.Name = "btnViewRecords";
            btnViewRecords.Size = new Size(150, 30);
            btnViewRecords.TabIndex = 0;
            btnViewRecords.Text = "기록 보기";
            btnViewRecords.UseVisualStyleBackColor = true;
            btnViewRecords.Click += btnViewRecords_Click;
            // 
            // btnHow
            // 
            btnHow.Location = new Point(393, 324);
            btnHow.Name = "btnHow";
            btnHow.Size = new Size(119, 30);
            btnHow.TabIndex = 2;
            btnHow.Text = "게임방법";
            btnHow.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            BackgroundImage = Properties.Resources.card7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 450);
            Controls.Add(btnHow);
            Controls.Add(btnViewRecords);
            Controls.Add(btnStartGame);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MSGAME";
            ResumeLayout(false);
        }

        private Button btnHow;
    }
}
