using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MSG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // 게임 폼 열기
            GameForm recordForm = new GameForm();
            recordForm.ShowDialog();
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            // 게임 기록 보기 폼을 열기
            RecordForm recordForm = new RecordForm();
            recordForm.ShowDialog();
        }
        private void btnHow_Click(object sender, EventArgs e)
        {
            // 게임 방법 폼을 열기
            HowToPlayForm HowToPlayForm = new HowToPlayForm();
            HowToPlayForm.ShowDialog();
        }
    }
}