using NAudio.Gui;

namespace MusicLibrary
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblHeader = new Label();
            trvDirectories = new TreeView();
            ctxTreeNode = new ContextMenuStrip(components);
            menuAddToPlayList = new ToolStripMenuItem();
            treeview_icons = new ImageList(components);
            btnExit = new Button();
            volumeSlider1 = new VolumeSlider();
            media_icons = new ImageList(components);
            btnPlay = new Button();
            btnPause = new Button();
            trbSeeker = new TrackBar();
            lblSeekMin = new Label();
            lblSeekMax = new Label();
            tmrSeekBar = new System.Windows.Forms.Timer(components);
            btnStop = new Button();
            grpDetails = new GroupBox();
            txtAlbum = new TextBox();
            txtArtist = new TextBox();
            txtTitle = new TextBox();
            lblAlbum = new Label();
            lblArtist = new Label();
            lblTitle = new Label();
            grdNowPlaying = new DataGridView();
            ctxDataGrid = new ContextMenuStrip(components);
            menuRemove = new ToolStripMenuItem();
            btnNext = new Button();
            btnPrevious = new Button();
            rdDefault = new RadioButton();
            rdRepeatList = new RadioButton();
            rdRepeatOne = new RadioButton();
            grpRepeat = new GroupBox();
            btnAddFolder = new Button();
            fldAddMusicFolder = new FolderBrowserDialog();
            cmbPlaylist = new ComboBox();
            btnCreatePlaylist = new Button();
            btnDeletePlaylist = new Button();
            prgAddAlbum = new ProgressBar();
            grpTreeView = new GroupBox();
            btnFind = new Button();
            txtFind = new TextBox();
            cmbFind = new ComboBox();
            btnDeleteFolder = new Button();
            lblUsername = new Label();
            lblRole = new Label();
            ctxTreeNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbSeeker).BeginInit();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdNowPlaying).BeginInit();
            ctxDataGrid.SuspendLayout();
            grpRepeat.SuspendLayout();
            grpTreeView.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(281, -7);
            lblHeader.Margin = new Padding(5, 0, 5, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(964, 88);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "MUSIC LIBRARY MANAGER\r\n\r\n";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trvDirectories
            // 
            trvDirectories.BackColor = Color.Black;
            trvDirectories.BorderStyle = BorderStyle.None;
            trvDirectories.ContextMenuStrip = ctxTreeNode;
            trvDirectories.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trvDirectories.ForeColor = Color.White;
            trvDirectories.ImageIndex = 0;
            trvDirectories.ImageList = treeview_icons;
            trvDirectories.LineColor = Color.White;
            trvDirectories.Location = new Point(10, 41);
            trvDirectories.Margin = new Padding(5, 6, 5, 6);
            trvDirectories.Name = "trvDirectories";
            trvDirectories.SelectedImageIndex = 1;
            trvDirectories.Size = new Size(330, 698);
            trvDirectories.TabIndex = 6;
            trvDirectories.NodeMouseDoubleClick += trvDirectories_NodeMouseDoubleClick;
            trvDirectories.MouseClick += trvDirectories_MouseClick;
            // 
            // ctxTreeNode
            // 
            ctxTreeNode.Items.AddRange(new ToolStripItem[] { menuAddToPlayList });
            ctxTreeNode.Name = "ctxTreeNode";
            ctxTreeNode.Size = new Size(192, 26);
            ctxTreeNode.ItemClicked += ctxTreeNode_ItemClicked;
            // 
            // menuAddToPlayList
            // 
            menuAddToPlayList.Name = "menuAddToPlayList";
            menuAddToPlayList.Size = new Size(191, 22);
            menuAddToPlayList.Text = "Add to current playlist";
            // 
            // treeview_icons
            // 
            treeview_icons.ColorDepth = ColorDepth.Depth32Bit;
            treeview_icons.ImageStream = (ImageListStreamer)resources.GetObject("treeview_icons.ImageStream");
            treeview_icons.TransparentColor = Color.Black;
            treeview_icons.Images.SetKeyName(0, "folder.png");
            treeview_icons.Images.SetKeyName(1, "mp3-file.png");
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1261, 788);
            btnExit.Margin = new Padding(5, 6, 5, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 69);
            btnExit.TabIndex = 7;
            btnExit.Text = "Log out";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // volumeSlider1
            // 
            volumeSlider1.BackColor = SystemColors.Control;
            volumeSlider1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeSlider1.Location = new Point(457, 126);
            volumeSlider1.Margin = new Padding(4, 5, 4, 5);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new Size(120, 31);
            volumeSlider1.TabIndex = 8;
            volumeSlider1.Volume = 0.15F;
            volumeSlider1.VolumeChanged += volumeSlider1_VolumeChanged;
            // 
            // media_icons
            // 
            media_icons.ColorDepth = ColorDepth.Depth32Bit;
            media_icons.ImageStream = (ImageListStreamer)resources.GetObject("media_icons.ImageStream");
            media_icons.TransparentColor = Color.Transparent;
            media_icons.Images.SetKeyName(0, "play-button.png");
            media_icons.Images.SetKeyName(1, "pause.png");
            media_icons.Images.SetKeyName(2, "stop.png");
            media_icons.Images.SetKeyName(3, "next.png");
            media_icons.Images.SetKeyName(4, "previous.png");
            media_icons.Images.SetKeyName(5, "add-folder.png");
            media_icons.Images.SetKeyName(6, "add-list.png");
            media_icons.Images.SetKeyName(7, "delete-list.png");
            media_icons.Images.SetKeyName(8, "delete-folder.png");
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.Enabled = false;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.ImageIndex = 0;
            btnPlay.ImageList = media_icons;
            btnPlay.Location = new Point(467, 250);
            btnPlay.Margin = new Padding(5, 6, 5, 6);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(64, 64);
            btnPlay.TabIndex = 9;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Transparent;
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.ImageIndex = 1;
            btnPause.ImageList = media_icons;
            btnPause.Location = new Point(541, 248);
            btnPause.Margin = new Padding(5, 6, 5, 6);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(64, 64);
            btnPause.TabIndex = 10;
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // trbSeeker
            // 
            trbSeeker.AutoSize = false;
            trbSeeker.Location = new Point(457, 168);
            trbSeeker.Margin = new Padding(5, 6, 5, 6);
            trbSeeker.Name = "trbSeeker";
            trbSeeker.Size = new Size(913, 34);
            trbSeeker.TabIndex = 11;
            trbSeeker.TickStyle = TickStyle.None;
            trbSeeker.MouseDown += trbSeeker_MouseDown;
            trbSeeker.MouseUp += trbSeeker_MouseUp;
            // 
            // lblSeekMin
            // 
            lblSeekMin.AutoSize = true;
            lblSeekMin.BackColor = Color.Transparent;
            lblSeekMin.Font = new Font("Segoe UI", 15F);
            lblSeekMin.ForeColor = Color.White;
            lblSeekMin.Location = new Point(378, 168);
            lblSeekMin.Margin = new Padding(5, 0, 5, 0);
            lblSeekMin.Name = "lblSeekMin";
            lblSeekMin.Size = new Size(60, 28);
            lblSeekMin.TabIndex = 12;
            lblSeekMin.Text = "00:00";
            // 
            // lblSeekMax
            // 
            lblSeekMax.AutoSize = true;
            lblSeekMax.BackColor = Color.Transparent;
            lblSeekMax.Font = new Font("Segoe UI", 15F);
            lblSeekMax.ForeColor = Color.White;
            lblSeekMax.Location = new Point(1380, 168);
            lblSeekMax.Margin = new Padding(5, 0, 5, 0);
            lblSeekMax.Name = "lblSeekMax";
            lblSeekMax.Size = new Size(49, 28);
            lblSeekMax.TabIndex = 13;
            lblSeekMax.Text = "0:00";
            // 
            // tmrSeekBar
            // 
            tmrSeekBar.Tick += tmrSeekBar_Tick;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Transparent;
            btnStop.Enabled = false;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.ImageIndex = 2;
            btnStop.ImageList = media_icons;
            btnStop.Location = new Point(615, 250);
            btnStop.Margin = new Padding(5, 6, 5, 6);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(64, 64);
            btnStop.TabIndex = 14;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // grpDetails
            // 
            grpDetails.BackColor = Color.Transparent;
            grpDetails.Controls.Add(txtAlbum);
            grpDetails.Controls.Add(txtArtist);
            grpDetails.Controls.Add(txtTitle);
            grpDetails.Controls.Add(lblAlbum);
            grpDetails.Controls.Add(lblArtist);
            grpDetails.Controls.Add(lblTitle);
            grpDetails.Font = new Font("Segoe UI", 15F);
            grpDetails.ForeColor = Color.White;
            grpDetails.Location = new Point(391, 668);
            grpDetails.Margin = new Padding(5, 6, 5, 6);
            grpDetails.Name = "grpDetails";
            grpDetails.Padding = new Padding(5, 6, 5, 6);
            grpDetails.Size = new Size(414, 286);
            grpDetails.TabIndex = 15;
            grpDetails.TabStop = false;
            grpDetails.Text = "Details";
            // 
            // txtAlbum
            // 
            txtAlbum.Enabled = false;
            txtAlbum.Location = new Point(126, 218);
            txtAlbum.Margin = new Padding(5, 6, 5, 6);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(278, 34);
            txtAlbum.TabIndex = 5;
            // 
            // txtArtist
            // 
            txtArtist.Enabled = false;
            txtArtist.Location = new Point(126, 133);
            txtArtist.Margin = new Padding(5, 6, 5, 6);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(278, 34);
            txtArtist.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.Enabled = false;
            txtTitle.Location = new Point(126, 49);
            txtTitle.Margin = new Padding(5, 6, 5, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(278, 34);
            txtTitle.TabIndex = 3;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Location = new Point(21, 224);
            lblAlbum.Margin = new Padding(5, 0, 5, 0);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(70, 28);
            lblAlbum.TabIndex = 2;
            lblAlbum.Text = "Album";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(21, 138);
            lblArtist.Margin = new Padding(5, 0, 5, 0);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(59, 28);
            lblArtist.TabIndex = 1;
            lblArtist.Text = "Artist";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(21, 54);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(49, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // grdNowPlaying
            // 
            grdNowPlaying.AllowUserToAddRows = false;
            grdNowPlaying.AllowUserToDeleteRows = false;
            grdNowPlaying.AllowUserToOrderColumns = true;
            grdNowPlaying.AllowUserToResizeRows = false;
            grdNowPlaying.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdNowPlaying.BackgroundColor = Color.Black;
            grdNowPlaying.BorderStyle = BorderStyle.None;
            grdNowPlaying.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdNowPlaying.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdNowPlaying.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdNowPlaying.ContextMenuStrip = ctxDataGrid;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdNowPlaying.DefaultCellStyle = dataGridViewCellStyle2;
            grdNowPlaying.Location = new Point(378, 326);
            grdNowPlaying.Margin = new Padding(5, 6, 5, 6);
            grdNowPlaying.Name = "grdNowPlaying";
            grdNowPlaying.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdNowPlaying.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdNowPlaying.RowHeadersVisible = false;
            grdNowPlaying.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdNowPlaying.ShowCellToolTips = false;
            grdNowPlaying.Size = new Size(1057, 330);
            grdNowPlaying.TabIndex = 16;
            grdNowPlaying.CellClick += grdNowPlaying_CellClick;
            grdNowPlaying.CellDoubleClick += grdNowPlaying_CellDoubleClick;
            // 
            // ctxDataGrid
            // 
            ctxDataGrid.Items.AddRange(new ToolStripItem[] { menuRemove });
            ctxDataGrid.Name = "ctxDataGrid";
            ctxDataGrid.Size = new Size(187, 26);
            ctxDataGrid.ItemClicked += ctxDataGrid_ItemClicked;
            // 
            // menuRemove
            // 
            menuRemove.Name = "menuRemove";
            menuRemove.Size = new Size(186, 22);
            menuRemove.Text = "Remove from playlist";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ImageIndex = 3;
            btnNext.ImageList = media_icons;
            btnNext.Location = new Point(689, 252);
            btnNext.Margin = new Padding(5, 6, 5, 6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(64, 64);
            btnNext.TabIndex = 17;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Transparent;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.ImageIndex = 4;
            btnPrevious.ImageList = media_icons;
            btnPrevious.Location = new Point(393, 250);
            btnPrevious.Margin = new Padding(5, 6, 5, 6);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(64, 64);
            btnPrevious.TabIndex = 18;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // rdDefault
            // 
            rdDefault.AutoSize = true;
            rdDefault.Location = new Point(16, 54);
            rdDefault.Margin = new Padding(5, 6, 5, 6);
            rdDefault.Name = "rdDefault";
            rdDefault.Size = new Size(118, 32);
            rdDefault.TabIndex = 19;
            rdDefault.TabStop = true;
            rdDefault.Text = "No repeat";
            rdDefault.UseVisualStyleBackColor = true;
            rdDefault.CheckedChanged += rdRepeat_CheckedChanged;
            // 
            // rdRepeatList
            // 
            rdRepeatList.AutoSize = true;
            rdRepeatList.Checked = true;
            rdRepeatList.Location = new Point(16, 133);
            rdRepeatList.Margin = new Padding(5, 6, 5, 6);
            rdRepeatList.Name = "rdRepeatList";
            rdRepeatList.Size = new Size(120, 32);
            rdRepeatList.TabIndex = 20;
            rdRepeatList.TabStop = true;
            rdRepeatList.Text = "Repeat list";
            rdRepeatList.UseVisualStyleBackColor = true;
            rdRepeatList.CheckedChanged += rdRepeat_CheckedChanged;
            // 
            // rdRepeatOne
            // 
            rdRepeatOne.AutoSize = true;
            rdRepeatOne.Location = new Point(16, 218);
            rdRepeatOne.Margin = new Padding(5, 6, 5, 6);
            rdRepeatOne.Name = "rdRepeatOne";
            rdRepeatOne.Size = new Size(128, 32);
            rdRepeatOne.TabIndex = 21;
            rdRepeatOne.TabStop = true;
            rdRepeatOne.Text = "Repeat one";
            rdRepeatOne.UseVisualStyleBackColor = true;
            rdRepeatOne.CheckedChanged += rdRepeat_CheckedChanged;
            // 
            // grpRepeat
            // 
            grpRepeat.BackColor = Color.Transparent;
            grpRepeat.Controls.Add(rdRepeatOne);
            grpRepeat.Controls.Add(rdRepeatList);
            grpRepeat.Controls.Add(rdDefault);
            grpRepeat.Font = new Font("Segoe UI", 15F);
            grpRepeat.ForeColor = Color.White;
            grpRepeat.Location = new Point(815, 668);
            grpRepeat.Margin = new Padding(5, 6, 5, 6);
            grpRepeat.Name = "grpRepeat";
            grpRepeat.Padding = new Padding(5, 6, 5, 6);
            grpRepeat.Size = new Size(208, 286);
            grpRepeat.TabIndex = 22;
            grpRepeat.TabStop = false;
            grpRepeat.Text = "Repeat mode";
            // 
            // btnAddFolder
            // 
            btnAddFolder.BackColor = Color.Transparent;
            btnAddFolder.FlatAppearance.BorderSize = 0;
            btnAddFolder.FlatStyle = FlatStyle.Flat;
            btnAddFolder.ImageIndex = 5;
            btnAddFolder.ImageList = media_icons;
            btnAddFolder.Location = new Point(18, 77);
            btnAddFolder.Margin = new Padding(5, 6, 5, 6);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new Size(64, 64);
            btnAddFolder.TabIndex = 23;
            btnAddFolder.UseVisualStyleBackColor = false;
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // cmbPlaylist
            // 
            cmbPlaylist.FormattingEnabled = true;
            cmbPlaylist.Location = new Point(1228, 259);
            cmbPlaylist.Margin = new Padding(5, 6, 5, 6);
            cmbPlaylist.Name = "cmbPlaylist";
            cmbPlaylist.Size = new Size(187, 36);
            cmbPlaylist.TabIndex = 24;
            cmbPlaylist.SelectedValueChanged += cmbPlaylist_SelectedValueChanged;
            // 
            // btnCreatePlaylist
            // 
            btnCreatePlaylist.BackColor = Color.Transparent;
            btnCreatePlaylist.FlatAppearance.BorderSize = 0;
            btnCreatePlaylist.FlatStyle = FlatStyle.Flat;
            btnCreatePlaylist.ForeColor = Color.White;
            btnCreatePlaylist.ImageIndex = 6;
            btnCreatePlaylist.ImageList = media_icons;
            btnCreatePlaylist.Location = new Point(1080, 250);
            btnCreatePlaylist.Margin = new Padding(5, 6, 5, 6);
            btnCreatePlaylist.Name = "btnCreatePlaylist";
            btnCreatePlaylist.Size = new Size(64, 64);
            btnCreatePlaylist.TabIndex = 25;
            btnCreatePlaylist.UseVisualStyleBackColor = false;
            btnCreatePlaylist.Click += btnCreatePlaylist_Click;
            // 
            // btnDeletePlaylist
            // 
            btnDeletePlaylist.BackColor = Color.Transparent;
            btnDeletePlaylist.FlatAppearance.BorderSize = 0;
            btnDeletePlaylist.FlatStyle = FlatStyle.Flat;
            btnDeletePlaylist.ForeColor = Color.White;
            btnDeletePlaylist.ImageIndex = 7;
            btnDeletePlaylist.ImageList = media_icons;
            btnDeletePlaylist.Location = new Point(1154, 250);
            btnDeletePlaylist.Margin = new Padding(5, 6, 5, 6);
            btnDeletePlaylist.Name = "btnDeletePlaylist";
            btnDeletePlaylist.Size = new Size(64, 64);
            btnDeletePlaylist.TabIndex = 26;
            btnDeletePlaylist.UseVisualStyleBackColor = false;
            btnDeletePlaylist.Click += btnDeletePlaylist_Click;
            // 
            // prgAddAlbum
            // 
            prgAddAlbum.Location = new Point(210, 101);
            prgAddAlbum.Margin = new Padding(5, 6, 5, 6);
            prgAddAlbum.Name = "prgAddAlbum";
            prgAddAlbum.Size = new Size(158, 43);
            prgAddAlbum.TabIndex = 27;
            prgAddAlbum.Visible = false;
            // 
            // grpTreeView
            // 
            grpTreeView.BackColor = Color.Transparent;
            grpTreeView.Controls.Add(btnFind);
            grpTreeView.Controls.Add(txtFind);
            grpTreeView.Controls.Add(cmbFind);
            grpTreeView.Controls.Add(trvDirectories);
            grpTreeView.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpTreeView.ForeColor = Color.White;
            grpTreeView.Location = new Point(18, 155);
            grpTreeView.Margin = new Padding(5, 6, 5, 6);
            grpTreeView.Name = "grpTreeView";
            grpTreeView.Padding = new Padding(5, 6, 5, 6);
            grpTreeView.Size = new Size(348, 799);
            grpTreeView.TabIndex = 28;
            grpTreeView.TabStop = false;
            grpTreeView.Text = "Library";
            // 
            // btnFind
            // 
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Location = new Point(229, 748);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(111, 36);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // txtFind
            // 
            txtFind.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFind.Location = new Point(96, 750);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(127, 34);
            txtFind.TabIndex = 8;
            // 
            // cmbFind
            // 
            cmbFind.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFind.FormattingEnabled = true;
            cmbFind.Items.AddRange(new object[] { "Artist", "Album", "Song" });
            cmbFind.Location = new Point(10, 748);
            cmbFind.Name = "cmbFind";
            cmbFind.Size = new Size(80, 36);
            cmbFind.TabIndex = 7;
            // 
            // btnDeleteFolder
            // 
            btnDeleteFolder.BackColor = Color.Transparent;
            btnDeleteFolder.FlatAppearance.BorderSize = 0;
            btnDeleteFolder.FlatStyle = FlatStyle.Flat;
            btnDeleteFolder.ImageIndex = 8;
            btnDeleteFolder.ImageList = media_icons;
            btnDeleteFolder.Location = new Point(92, 79);
            btnDeleteFolder.Margin = new Padding(5, 6, 5, 6);
            btnDeleteFolder.Name = "btnDeleteFolder";
            btnDeleteFolder.Size = new Size(64, 64);
            btnDeleteFolder.TabIndex = 29;
            btnDeleteFolder.UseVisualStyleBackColor = false;
            btnDeleteFolder.Click += btnDeleteFolder_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(12, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 28);
            lblUsername.TabIndex = 30;
            lblUsername.Text = "Username: ";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(12, 43);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(59, 28);
            lblRole.TabIndex = 31;
            lblRole.Text = "Role: ";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1453, 958);
            ControlBox = false;
            Controls.Add(lblRole);
            Controls.Add(lblUsername);
            Controls.Add(btnDeleteFolder);
            Controls.Add(grpTreeView);
            Controls.Add(prgAddAlbum);
            Controls.Add(btnDeletePlaylist);
            Controls.Add(btnCreatePlaylist);
            Controls.Add(cmbPlaylist);
            Controls.Add(btnAddFolder);
            Controls.Add(grpRepeat);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(grdNowPlaying);
            Controls.Add(grpDetails);
            Controls.Add(btnStop);
            Controls.Add(lblSeekMax);
            Controls.Add(lblSeekMin);
            Controls.Add(trbSeeker);
            Controls.Add(btnPause);
            Controls.Add(btnPlay);
            Controls.Add(btnExit);
            Controls.Add(lblHeader);
            Controls.Add(volumeSlider1);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ctxTreeNode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trbSeeker).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdNowPlaying).EndInit();
            ctxDataGrid.ResumeLayout(false);
            grpRepeat.ResumeLayout(false);
            grpRepeat.PerformLayout();
            grpTreeView.ResumeLayout(false);
            grpTreeView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private TreeView trvDirectories;
        private Button btnExit;
        private VolumeSlider volumeSlider1;
        private ImageList media_icons;
        private Button btnPlay;
        private Button btnPause;
        private TrackBar trbSeeker;
        private Label lblSeekMin;
        private Label lblSeekMax;
        private System.Windows.Forms.Timer tmrSeekBar;
        private ImageList treeview_icons;
        private Button btnStop;
        private ContextMenuStrip ctxTreeNode;
        private ToolStripMenuItem menuAddToPlayList;
        private GroupBox grpDetails;
        private Label lblAlbum;
        private Label lblArtist;
        private Label lblTitle;
        private TextBox txtAlbum;
        private TextBox txtArtist;
        private TextBox txtTitle;
        private DataGridView grdNowPlaying;
        private Button btnNext;
        private Button btnPrevious;
        private RadioButton rdDefault;
        private RadioButton rdRepeatList;
        private RadioButton rdRepeatOne;
        private GroupBox grpRepeat;
        private Button btnAddFolder;
        private FolderBrowserDialog fldAddMusicFolder;
        private ContextMenuStrip ctxDataGrid;
        private ToolStripMenuItem menuRemove;
        private ComboBox cmbPlaylist;
        private Button btnCreatePlaylist;
        private Button btnDeletePlaylist;
        private ProgressBar prgAddAlbum;
        private GroupBox grpTreeView;
        private Button btnDeleteFolder;
        private ComboBox cmbFind;
        private Button btnFind;
        private TextBox txtFind;
        private Label lblUsername;
        private Label lblRole;
    }
}