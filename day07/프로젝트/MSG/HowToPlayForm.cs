using System;
using System.Windows.Forms;

namespace MSG
{
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();
        }

        private void HowToPlayForm_Load(object sender, EventArgs e)
        {
            // 게임 방법을 보여줄 내용을 여기에 추가
            lblHowToPlay.Text = "게임 방법:\n1. [게임 시작] 버튼을 눌러 게임을 시작하세요.\n2. 1~100 사이의 숫자를 입력하세요.\n3. 컴퓨터가 생각한 숫자를 맞추세요.\n4. 목숨을 모두 소진하면 게임이 종료됩니다.";
        }
    }
}
