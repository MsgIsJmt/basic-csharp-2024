namespace MyExplorer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            BtnOpen = new Button();
            TxtPath = new TextBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            TrvFolder = new TreeView();
            ImgSmallIcon = new ImageList(components);
            LsvFiles = new ListView();
            ClhTitle = new ColumnHeader();
            ClhModifiedDate = new ColumnHeader();
            ClhType = new ColumnHeader();
            ClhSize = new ColumnHeader();
            ImgLargeIcon = new ImageList(components);
            CmsFiles = new ContextMenuStrip(components);
            보기ToolStripMenuItem = new ToolStripMenuItem();
            큰아이콘ToolStripMenuItem = new ToolStripMenuItem();
            작은아이콘ToolStripMenuItem = new ToolStripMenuItem();
            목록ToolStripMenuItem = new ToolStripMenuItem();
            자세히ToolStripMenuItem = new ToolStripMenuItem();
            타일ToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            CmsFiles.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(BtnOpen);
            panel1.Controls.Add(TxtPath);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 38);
            panel1.TabIndex = 1;
            // 
            // BtnOpen
            // 
            BtnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnOpen.BackColor = SystemColors.Control;
            BtnOpen.Location = new Point(736, 6);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(61, 23);
            BtnOpen.TabIndex = 0;
            BtnOpen.Text = "열기";
            BtnOpen.UseVisualStyleBackColor = false;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // TxtPath
            // 
            TxtPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPath.Location = new Point(49, 6);
            TxtPath.Name = "TxtPath";
            TxtPath.ReadOnly = true;
            TxtPath.Size = new Size(681, 23);
            TxtPath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "경로";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 38);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TrvFolder);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(LsvFiles);
            splitContainer1.Size = new Size(809, 401);
            splitContainer1.SplitterDistance = 269;
            splitContainer1.TabIndex = 2;
            // 
            // TrvFolder
            // 
            TrvFolder.BorderStyle = BorderStyle.None;
            TrvFolder.Dock = DockStyle.Fill;
            TrvFolder.ImageIndex = 0;
            TrvFolder.ImageList = ImgSmallIcon;
            TrvFolder.Location = new Point(0, 0);
            TrvFolder.Name = "TrvFolder";
            TrvFolder.SelectedImageIndex = 0;
            TrvFolder.Size = new Size(269, 401);
            TrvFolder.TabIndex = 0;
            TrvFolder.BeforeExpand += TrvFolder_BeforeExpand;
            TrvFolder.AfterSelect += TrvFolder_AfterSelect;
            // 
            // ImgSmallIcon
            // 
            ImgSmallIcon.ColorDepth = ColorDepth.Depth32Bit;
            ImgSmallIcon.ImageStream = (ImageListStreamer)resources.GetObject("ImgSmallIcon.ImageStream");
            ImgSmallIcon.TransparentColor = Color.Transparent;
            ImgSmallIcon.Images.SetKeyName(0, "hard-drive.png");
            ImgSmallIcon.Images.SetKeyName(1, "folder-normal.png");
            ImgSmallIcon.Images.SetKeyName(2, "folder-open.png");
            ImgSmallIcon.Images.SetKeyName(3, "file-exe.png");
            ImgSmallIcon.Images.SetKeyName(4, "file-normal.png");
            ImgSmallIcon.Images.SetKeyName(5, "txt.png");
            // 
            // LsvFiles
            // 
            LsvFiles.BorderStyle = BorderStyle.None;
            LsvFiles.Columns.AddRange(new ColumnHeader[] { ClhTitle, ClhModifiedDate, ClhType, ClhSize });
            LsvFiles.Dock = DockStyle.Fill;
            LsvFiles.LargeImageList = ImgLargeIcon;
            LsvFiles.Location = new Point(0, 0);
            LsvFiles.Name = "LsvFiles";
            LsvFiles.Size = new Size(536, 401);
            LsvFiles.SmallImageList = ImgSmallIcon;
            LsvFiles.TabIndex = 0;
            LsvFiles.UseCompatibleStateImageBehavior = false;
            LsvFiles.View = View.Details;
            LsvFiles.MouseClick += LsvFiles_MouseClick;
            // 
            // ClhTitle
            // 
            ClhTitle.Text = "이름";
            ClhTitle.Width = 200;
            // 
            // ClhModifiedDate
            // 
            ClhModifiedDate.Text = "수정일자";
            ClhModifiedDate.Width = 100;
            // 
            // ClhType
            // 
            ClhType.Text = "유형";
            ClhType.Width = 100;
            // 
            // ClhSize
            // 
            ClhSize.Text = "크기";
            ClhSize.TextAlign = HorizontalAlignment.Right;
            ClhSize.Width = 100;
            // 
            // ImgLargeIcon
            // 
            ImgLargeIcon.ColorDepth = ColorDepth.Depth32Bit;
            ImgLargeIcon.ImageStream = (ImageListStreamer)resources.GetObject("ImgLargeIcon.ImageStream");
            ImgLargeIcon.TransparentColor = Color.Transparent;
            ImgLargeIcon.Images.SetKeyName(0, "hard-drive.png");
            ImgLargeIcon.Images.SetKeyName(1, "folder-normal.png");
            ImgLargeIcon.Images.SetKeyName(2, "folder-open.png");
            ImgLargeIcon.Images.SetKeyName(3, "file-exe.png");
            ImgLargeIcon.Images.SetKeyName(4, "file-normal.png");
            ImgLargeIcon.Images.SetKeyName(5, "txt.png");
            // 
            // CmsFiles
            // 
            CmsFiles.Items.AddRange(new ToolStripItem[] { 보기ToolStripMenuItem });
            CmsFiles.Name = "CmsFiles";
            CmsFiles.Size = new Size(99, 26);
            // 
            // 보기ToolStripMenuItem
            // 
            보기ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 큰아이콘ToolStripMenuItem, 작은아이콘ToolStripMenuItem, 목록ToolStripMenuItem, 자세히ToolStripMenuItem, 타일ToolStripMenuItem });
            보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            보기ToolStripMenuItem.Size = new Size(98, 22);
            보기ToolStripMenuItem.Text = "보기";
            // 
            // 큰아이콘ToolStripMenuItem
            // 
            큰아이콘ToolStripMenuItem.Name = "큰아이콘ToolStripMenuItem";
            큰아이콘ToolStripMenuItem.Size = new Size(138, 22);
            큰아이콘ToolStripMenuItem.Text = "큰 아이콘";
            // 
            // 작은아이콘ToolStripMenuItem
            // 
            작은아이콘ToolStripMenuItem.Name = "작은아이콘ToolStripMenuItem";
            작은아이콘ToolStripMenuItem.Size = new Size(138, 22);
            작은아이콘ToolStripMenuItem.Text = "작은 아이콘";
            // 
            // 목록ToolStripMenuItem
            // 
            목록ToolStripMenuItem.Name = "목록ToolStripMenuItem";
            목록ToolStripMenuItem.Size = new Size(138, 22);
            목록ToolStripMenuItem.Text = "목록";
            // 
            // 자세히ToolStripMenuItem
            // 
            자세히ToolStripMenuItem.Name = "자세히ToolStripMenuItem";
            자세히ToolStripMenuItem.Size = new Size(138, 22);
            자세히ToolStripMenuItem.Text = "자세히";
            // 
            // 타일ToolStripMenuItem
            // 
            타일ToolStripMenuItem.Name = "타일ToolStripMenuItem";
            타일ToolStripMenuItem.Size = new Size(138, 22);
            타일ToolStripMenuItem.Text = "타일";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 439);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "내 탐색기 v1.0";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            CmsFiles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnOpen;
        private TextBox TxtPath;
        private Label label1;
        private SplitContainer splitContainer1;
        private TreeView TrvFolder;
        private ListView LsvFiles;
        private ColumnHeader ClhTitle;
        private ColumnHeader ClhType;
        private ColumnHeader ClhModifiedDate;
        private ColumnHeader ClhSize;
        private ImageList ImgSmallIcon;
        private ImageList ImgLargeIcon;
        private ContextMenuStrip CmsFiles;
        private ToolStripMenuItem 보기ToolStripMenuItem;
        private ToolStripMenuItem 큰아이콘ToolStripMenuItem;
        private ToolStripMenuItem 작은아이콘ToolStripMenuItem;
        private ToolStripMenuItem 목록ToolStripMenuItem;
        private ToolStripMenuItem 자세히ToolStripMenuItem;
        private ToolStripMenuItem 타일ToolStripMenuItem;
    }
}