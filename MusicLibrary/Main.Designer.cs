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
            btnNext = new Button();
            btnPrevious = new Button();
            ctxTreeNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbSeeker).BeginInit();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdNowPlaying).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Blue;
            lblHeader.Location = new Point(107, -1);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(614, 47);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "MUSIC LIBRARY MANAGER\r\n\r\n";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trvDirectories
            // 
            trvDirectories.ContextMenuStrip = ctxTreeNode;
            trvDirectories.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trvDirectories.ImageIndex = 0;
            trvDirectories.ImageList = treeview_icons;
            trvDirectories.Location = new Point(0, 66);
            trvDirectories.Name = "trvDirectories";
            trvDirectories.SelectedImageIndex = 1;
            trvDirectories.Size = new Size(234, 445);
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
            btnExit.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(681, 422);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 37);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // volumeSlider1
            // 
            volumeSlider1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeSlider1.Location = new Point(497, 136);
            volumeSlider1.Margin = new Padding(4, 5, 4, 5);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new Size(94, 18);
            volumeSlider1.TabIndex = 8;
            volumeSlider1.Volume = 0.6F;
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
            // 
            // btnPlay
            // 
            btnPlay.FlatAppearance.BorderColor = SystemColors.Control;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.ImageIndex = 0;
            btnPlay.ImageList = media_icons;
            btnPlay.Location = new Point(288, 129);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(48, 42);
            btnPlay.TabIndex = 9;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.FlatAppearance.BorderColor = SystemColors.Control;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.ImageIndex = 1;
            btnPause.ImageList = media_icons;
            btnPause.Location = new Point(342, 128);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(44, 42);
            btnPause.TabIndex = 10;
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // trbSeeker
            // 
            trbSeeker.Location = new Point(288, 83);
            trbSeeker.Name = "trbSeeker";
            trbSeeker.Size = new Size(581, 45);
            trbSeeker.TabIndex = 11;
            trbSeeker.TickStyle = TickStyle.None;
            trbSeeker.MouseDown += trbSeeker_MouseDown;
            trbSeeker.MouseUp += trbSeeker_MouseUp;
            // 
            // lblSeekMin
            // 
            lblSeekMin.AutoSize = true;
            lblSeekMin.Location = new Point(249, 83);
            lblSeekMin.Name = "lblSeekMin";
            lblSeekMin.Size = new Size(28, 15);
            lblSeekMin.TabIndex = 12;
            lblSeekMin.Text = "0:00";
            // 
            // lblSeekMax
            // 
            lblSeekMax.AutoSize = true;
            lblSeekMax.Location = new Point(875, 83);
            lblSeekMax.Name = "lblSeekMax";
            lblSeekMax.Size = new Size(28, 15);
            lblSeekMax.TabIndex = 13;
            lblSeekMax.Text = "0:00";
            // 
            // tmrSeekBar
            // 
            tmrSeekBar.Tick += tmrSeekBar_Tick;
            // 
            // btnStop
            // 
            btnStop.FlatAppearance.BorderColor = SystemColors.Control;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.ImageIndex = 2;
            btnStop.ImageList = media_icons;
            btnStop.Location = new Point(449, 132);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(41, 35);
            btnStop.TabIndex = 14;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(txtAlbum);
            grpDetails.Controls.Add(txtArtist);
            grpDetails.Controls.Add(txtTitle);
            grpDetails.Controls.Add(lblAlbum);
            grpDetails.Controls.Add(lblArtist);
            grpDetails.Controls.Add(lblTitle);
            grpDetails.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDetails.Location = new Point(345, 358);
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
            grdNowPlaying.AllowUserToAddRows = false;
            grdNowPlaying.AllowUserToDeleteRows = false;
            grdNowPlaying.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdNowPlaying.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdNowPlaying.Location = new Point(240, 175);
            grdNowPlaying.Name = "grdNowPlaying";
            grdNowPlaying.ReadOnly = true;
            grdNowPlaying.Size = new Size(673, 177);
            grdNowPlaying.TabIndex = 16;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderColor = SystemColors.Control;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ImageIndex = 3;
            btnNext.ImageList = media_icons;
            btnNext.Location = new Point(392, 132);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(51, 36);
            btnNext.TabIndex = 17;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatAppearance.BorderColor = SystemColors.Control;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.ImageIndex = 4;
            btnPrevious.ImageList = media_icons;
            btnPrevious.Location = new Point(240, 128);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(51, 43);
            btnPrevious.TabIndex = 18;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 513);
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
            Controls.Add(trvDirectories);
            Controls.Add(lblHeader);
            Controls.Add(volumeSlider1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ctxTreeNode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trbSeeker).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdNowPlaying).EndInit();
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
    }
}