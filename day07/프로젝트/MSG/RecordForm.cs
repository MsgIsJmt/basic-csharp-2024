using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MSG
{
    public partial class RecordForm : Form
    {
        private List<(string playerName, int attempts)> winnersList = new List<(string playerName, int attempts)>();

        public RecordForm()
        {
            InitializeComponent();
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            LoadWinners();
        }

        private void LoadWinners()
        {
            string fileName = "winners.txt";
            if (File.Exists(fileName))
            {
                using (StreamReader file = new StreamReader(fileName))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string playerName = parts[0];
                            if (int.TryParse(parts[1], out int attempts))
                            {
                                winnersList.Add((playerName, attempts));
                            }
                        }
                    }
                }

                DisplayWinners();
            }
            else
            {
                MessageBox.Show("기록된 내용이 없습니다.");
            }
        }

        private void DisplayWinners()
        {
            dgvWinners.Rows.Clear();
            foreach (var winner in winnersList)
            {
                dgvWinners.Rows.Add(winner.playerName, winner.attempts);
            }
        }
    }
}
