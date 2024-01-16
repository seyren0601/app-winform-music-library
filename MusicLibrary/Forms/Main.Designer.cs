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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            lblHeader.Location = new Point(179, -4);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(614, 47);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "MUSIC LIBRARY MANAGER\r\n\r\n";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trvDirectories
            // 
            trvDirectories.BackColor = Color.Black;
            trvDirectories.BorderStyle = BorderStyle.None;
            trvDirectories.ContextMenuStrip = ctxTreeNode;
            trvDirectories.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trvDirectories.ForeColor = Color.White;
            trvDirectories.ImageIndex = 0;
            trvDirectories.ImageList = treeview_icons;
            trvDirectories.LineColor = Color.White;
            trvDirectories.Location = new Point(6, 22);
            trvDirectories.Name = "trvDirectories";
            trvDirectories.SelectedImageIndex = 1;
            trvDirectories.Size = new Size(210, 396);
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
            treeview_icons.TransparentColor = Color.Transparent;
            treeview_icons.Images.SetKeyName(0, "pngtree-vector-folder-icon-png-image_3788101.png");
            treeview_icons.Images.SetKeyName(1, "mp3-file.png");
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(803, 422);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 37);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // volumeSlider1
            // 
            volumeSlider1.BackColor = SystemColors.Control;
            volumeSlider1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeSlider1.Location = new Point(460, 144);
            volumeSlider1.Margin = new Padding(4, 5, 4, 5);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new Size(94, 18);
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
            media_icons.Images.SetKeyName(5, "add_folder.png");
            media_icons.Images.SetKeyName(6, "add-list.png");
            media_icons.Images.SetKeyName(7, "delete-list.png");
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.Enabled = false;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.ImageIndex = 0;
            btnPlay.ImageList = media_icons;
            btnPlay.Location = new Point(291, 133);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(36, 36);
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
            btnPause.Location = new Point(333, 133);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(36, 36);
            btnPause.TabIndex = 10;
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // trbSeeker
            // 
            trbSeeker.AutoSize = false;
            trbSeeker.Location = new Point(288, 83);
            trbSeeker.Name = "trbSeeker";
            trbSeeker.Size = new Size(581, 30);
            trbSeeker.TabIndex = 11;
            trbSeeker.TickStyle = TickStyle.None;
            trbSeeker.MouseDown += trbSeeker_MouseDown;
            trbSeeker.MouseUp += trbSeeker_MouseUp;
            // 
            // lblSeekMin
            // 
            lblSeekMin.AutoSize = true;
            lblSeekMin.BackColor = Color.Transparent;
            lblSeekMin.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeekMin.ForeColor = Color.White;
            lblSeekMin.Location = new Point(240, 83);
            lblSeekMin.Name = "lblSeekMin";
            lblSeekMin.Size = new Size(41, 23);
            lblSeekMin.TabIndex = 12;
            lblSeekMin.Text = "0:00";
            // 
            // lblSeekMax
            // 
            lblSeekMax.AutoSize = true;
            lblSeekMax.BackColor = Color.Transparent;
            lblSeekMax.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeekMax.ForeColor = Color.White;
            lblSeekMax.Location = new Point(875, 83);
            lblSeekMax.Name = "lblSeekMax";
            lblSeekMax.Size = new Size(41, 23);
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
            btnStop.Location = new Point(375, 133);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(36, 36);
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
            grpDetails.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDetails.ForeColor = Color.White;
            grpDetails.Location = new Point(249, 358);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(264, 153);
            grpDetails.TabIndex = 15;
            grpDetails.TabStop = false;
            grpDetails.Text = "Details";
            // 
            // txtAlbum
            // 
            txtAlbum.Enabled = false;
            txtAlbum.Location = new Point(80, 117);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(178, 30);
            txtAlbum.TabIndex = 5;
            // 
            // txtArtist
            // 
            txtArtist.Enabled = false;
            txtArtist.Location = new Point(80, 71);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(178, 30);
            txtArtist.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.Enabled = false;
            txtTitle.Location = new Point(80, 26);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(178, 30);
            txtTitle.TabIndex = 3;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Location = new Point(13, 120);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(60, 23);
            lblAlbum.TabIndex = 2;
            lblAlbum.Text = "Album";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(13, 74);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(50, 23);
            lblArtist.TabIndex = 1;
            lblArtist.Text = "Artist";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(13, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // grdNowPlaying
            // 
            grdNowPlaying.AllowUserToOrderColumns = true;
            grdNowPlaying.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdNowPlaying.BackgroundColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Pristina", 13F);
            dataGridViewCellStyle3.ForeColor = Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdNowPlaying.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdNowPlaying.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdNowPlaying.ContextMenuStrip = ctxDataGrid;
            grdNowPlaying.Location = new Point(240, 175);
            grdNowPlaying.Name = "grdNowPlaying";
            grdNowPlaying.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Pristina", 13F);
            dataGridViewCellStyle4.ForeColor = Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdNowPlaying.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdNowPlaying.Size = new Size(673, 177);
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
            btnNext.Location = new Point(417, 133);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 36);
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
            btnPrevious.Location = new Point(249, 134);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(36, 36);
            btnPrevious.TabIndex = 18;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // rdDefault
            // 
            rdDefault.AutoSize = true;
            rdDefault.Location = new Point(10, 29);
            rdDefault.Name = "rdDefault";
            rdDefault.Size = new Size(105, 27);
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
            rdRepeatList.Location = new Point(10, 71);
            rdRepeatList.Name = "rdRepeatList";
            rdRepeatList.Size = new Size(107, 27);
            rdRepeatList.TabIndex = 20;
            rdRepeatList.TabStop = true;
            rdRepeatList.Text = "Repeat list";
            rdRepeatList.UseVisualStyleBackColor = true;
            rdRepeatList.CheckedChanged += rdRepeat_CheckedChanged;
            // 
            // rdRepeatOne
            // 
            rdRepeatOne.AutoSize = true;
            rdRepeatOne.Location = new Point(10, 117);
            rdRepeatOne.Name = "rdRepeatOne";
            rdRepeatOne.Size = new Size(115, 27);
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
            grpRepeat.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpRepeat.ForeColor = Color.White;
            grpRepeat.Location = new Point(519, 358);
            grpRepeat.Name = "grpRepeat";
            grpRepeat.Size = new Size(132, 153);
            grpRepeat.TabIndex = 22;
            grpRepeat.TabStop = false;
            grpRepeat.Text = "Repeat mode";
            // 
            // btnAddFolder
            // 
            btnAddFolder.BackColor = Color.Transparent;
            btnAddFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddFolder.FlatStyle = FlatStyle.Flat;
            btnAddFolder.ImageIndex = 5;
            btnAddFolder.ImageList = media_icons;
            btnAddFolder.Location = new Point(12, 41);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new Size(36, 36);
            btnAddFolder.TabIndex = 23;
            btnAddFolder.UseVisualStyleBackColor = false;
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // cmbPlaylist
            // 
            cmbPlaylist.FormattingEnabled = true;
            cmbPlaylist.Location = new Point(782, 139);
            cmbPlaylist.Name = "cmbPlaylist";
            cmbPlaylist.Size = new Size(121, 23);
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
            btnCreatePlaylist.Location = new Point(694, 135);
            btnCreatePlaylist.Name = "btnCreatePlaylist";
            btnCreatePlaylist.Size = new Size(36, 36);
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
            btnDeletePlaylist.Location = new Point(735, 134);
            btnDeletePlaylist.Name = "btnDeletePlaylist";
            btnDeletePlaylist.Size = new Size(36, 36);
            btnDeletePlaylist.TabIndex = 26;
            btnDeletePlaylist.UseVisualStyleBackColor = false;
            btnDeletePlaylist.Click += btnDeletePlaylist_Click;
            // 
            // prgAddAlbum
            // 
            prgAddAlbum.Location = new Point(134, 54);
            prgAddAlbum.Name = "prgAddAlbum";
            prgAddAlbum.Size = new Size(100, 23);
            prgAddAlbum.TabIndex = 27;
            prgAddAlbum.Visible = false;
            // 
            // grpTreeView
            // 
            grpTreeView.BackColor = Color.Transparent;
            grpTreeView.Controls.Add(trvDirectories);
            grpTreeView.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpTreeView.ForeColor = Color.White;
            grpTreeView.Location = new Point(12, 83);
            grpTreeView.Name = "grpTreeView";
            grpTreeView.Size = new Size(222, 428);
            grpTreeView.TabIndex = 28;
            grpTreeView.TabStop = false;
            grpTreeView.Text = "Library";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(925, 513);
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
            Name = "Main";
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
    }
}