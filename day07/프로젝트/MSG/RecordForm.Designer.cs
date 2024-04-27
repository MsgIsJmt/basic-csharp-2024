namespace MSG
{
    partial class RecordForm
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
            dgvWinners = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvWinners).BeginInit();
            SuspendLayout();
            // 
            // dgvWinners
            // 
            dgvWinners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWinners.Location = new Point(174, 188);
            dgvWinners.Name = "dgvWinners";
            dgvWinners.Size = new Size(240, 150);
            dgvWinners.TabIndex = 0;
            // 
            // RecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvWinners);
            Name = "RecordForm";
            Text = "ViewWinnersForm";
            ((System.ComponentModel.ISupportInitialize)dgvWinners).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvWinners;
    }
}