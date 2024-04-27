using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace MSG
{
    public partial class GameForm : Form
    {
        private int computerNumber; // �� �Ǹ��� ���� ����
        private int count = 0;
        private int lives = 10;
        private string currentPlayer = "";

        public GameForm()
        {
            InitializeComponent();
            computerNumber = GenerateRandomNumber(); // ���� ���� �� ���� ���� ����

            // txtInput ��Ʈ���� KeyDown �̺�Ʈ�� �����մϴ�.
            txtInput.KeyDown += new KeyEventHandler(txtInput_KeyDown);

            // ���� ���� �� Ȯ�� ��ư ��Ȱ��ȭ
            btnOK.Enabled = false;

            // ���� Ű�� ������ �� btnOK ��ư�� Ŭ���ǵ��� �����մϴ�.
            this.AcceptButton = btnOK;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "������ �����Ϸ��� [���� ����] ��ư�� Ŭ���ϼ���.";
            txtInput.Enabled = false;
            txtInput.KeyPress += new KeyPressEventHandler(txtInput_KeyPress); // ���� �Է� ����
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // �̸� �Է� ���� ��� �̸��� �Է¹޽��ϴ�.
            string input = Interaction.InputBox("�̸��� �Է��ϼ���:", "�÷��̾� �̸�", "");
            if (!string.IsNullOrEmpty(input))
            {
                currentPlayer = input;
                lblMessage.Text = "1~100 ������ ���ڸ� �Է��ϼ���.";
                lblResult.Text = "";
                lblLives.Text = $"���: {lives}";
                txtInput.Enabled = true;
                btnStart.Enabled = false;
                btnOK.Enabled = true;
            }
            else
            {
                MessageBox.Show("�̸��� �Է��ϼ���.");
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
            lblMessage.Text = "������ �����Ϸ��� [���� ����] ��ư�� Ŭ���ϼ���.";
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
                lblMessage.Text = "�ùٸ� ���ڸ� �Է��ϼ���.";
                txtInput.Focus();
                return;
            }

            if (n == computerNumber)
            {
                lblResult.Text = "�����Դϴ�.";
                txtInput.Enabled = false;

                SaveWinners();
                MessageBox.Show($"�����մϴ�, {currentPlayer}��! {count}�� ���� ������ ���߼̽��ϴ�.");
                RestartGame();
            }
            else if (n < computerNumber)
            {
                lblMessage.Text = "�� ū ���� �Է��ϼ���.";
            }
            else
            {
                lblMessage.Text = "�� ���� ���� �Է��ϼ���.";
            }

            count++;
            lives--;
            lblLives.Text = $"���: {lives}";

            if (lives <= 0)
            {
                MessageBox.Show("���� ���� - ����� ��� �����Ǿ����ϴ�.");
                RestartGame();
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ����(0-9)�� �齺���̽� Ű(ASCII �ڵ� 8)�� ���
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // �Է� ����
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // ����Ű �Է� ����
                btnOK_Click(sender, e); // Ȯ�� ��ư Ŭ�� �̺�Ʈ ȣ��
            }
        }

        private int GenerateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 101); // 1���� 100 ������ ���� ���� ��ȯ
        }
    }
}
