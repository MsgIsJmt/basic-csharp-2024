using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace MSG
{
    public partial class GameForm : Form
    {
        private int computerNumber; // 매 판마다 랜덤 숫자
        private int count = 0;
        private int lives = 10;
        private string currentPlayer = "";

        public GameForm()
        {
            InitializeComponent();
            computerNumber = GenerateRandomNumber(); // 게임 시작 시 랜덤 숫자 생성

            // txtInput 컨트롤의 KeyDown 이벤트를 설정합니다.
            txtInput.KeyDown += new KeyEventHandler(txtInput_KeyDown);

            // 게임 시작 전 확인 버튼 비활성화
            btnOK.Enabled = false;

            // 엔터 키를 눌렀을 때 btnOK 버튼이 클릭되도록 설정합니다.
            this.AcceptButton = btnOK;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "게임을 시작하려면 [게임 시작] 버튼을 클릭하세요.";
            txtInput.Enabled = false;
            txtInput.KeyPress += new KeyPressEventHandler(txtInput_KeyPress); // 숫자 입력 제한
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 이름 입력 폼을 열어서 이름을 입력받습니다.
            string input = Interaction.InputBox("이름을 입력하세요:", "플레이어 이름", "");
            if (!string.IsNullOrEmpty(input))
            {
                currentPlayer = input;
                lblMessage.Text = "1~100 사이의 숫자를 입력하세요.";
                lblResult.Text = "";
                lblLives.Text = $"목숨: {lives}";
                txtInput.Enabled = true;
                btnStart.Enabled = false;
                btnOK.Enabled = true;
            }
            else
            {
                MessageBox.Show("이름을 입력하세요.");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CheckGuess();
        }

        private void SaveWinners()
        {
            string fileName = "winners.txt";
            using (StreamWriter file = new StreamWriter(fileName, append: true))
            {
                file.WriteLine($"{currentPlayer},{count}");
            }
        }

        private void RestartGame()
        {
            btnStart.Enabled = true;
            btnOK.Enabled = false;
            txtInput.Text = "";
            txtInput.Enabled = false;
            lblMessage.Text = "게임을 시작하려면 [게임 시작] 버튼을 클릭하세요.";
            lblResult.Text = "";
            lblLives.Text = "";
            count = 0;
            lives = 10;
            currentPlayer = "";
        }

        private void CheckGuess()
        {
            int n;
            if (!int.TryParse(txtInput.Text, out n))
            {
                lblMessage.Text = "올바른 숫자를 입력하세요.";
                txtInput.Focus();
                return;
            }

            if (n == computerNumber)
            {
                lblResult.Text = "정답입니다.";
                txtInput.Enabled = false;

                SaveWinners();
                MessageBox.Show($"축하합니다, {currentPlayer}님! {count}번 만에 정답을 맞추셨습니다.");
                RestartGame();
            }
            else if (n < computerNumber)
            {
                lblMessage.Text = "더 큰 수를 입력하세요.";
            }
            else
            {
                lblMessage.Text = "더 작은 수를 입력하세요.";
            }

            count++;
            lives--;
            lblLives.Text = $"목숨: {lives}";

            if (lives <= 0)
            {
                MessageBox.Show("게임 종료 - 목숨이 모두 소진되었습니다.");
                RestartGame();
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자(0-9)와 백스페이스 키(ASCII 코드 8)만 허용
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // 입력 무시
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 엔터키 입력 무시
                btnOK_Click(sender, e); // 확인 버튼 클릭 이벤트 호출
            }
        }

        private int GenerateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 101); // 1부터 100 사이의 랜덤 숫자 반환
        }
    }
}
