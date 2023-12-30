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
            btnExit = new Button();
            volumeSlider1 = new VolumeSlider();
            icons = new ImageList(components);
            btnPlay = new Button();
            btnPause = new Button();
            trbSeeker = new TrackBar();
            lblSeekMin = new Label();
            lblSeekMax = new Label();
            tmrSeekBar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trbSeeker).BeginInit();
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
            trvDirectories.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trvDirectories.Location = new Point(0, 66);
            trvDirectories.Name = "trvDirectories";
            trvDirectories.Size = new Size(234, 385);
            trvDirectories.TabIndex = 6;
            trvDirectories.NodeMouseDoubleClick += trvDirectories_NodeMouseDoubleClick;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(700, 414);
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
            volumeSlider1.Location = new Point(260, 122);
            volumeSlider1.Margin = new Padding(4, 5, 4, 5);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new Size(94, 29);
            volumeSlider1.TabIndex = 8;
            volumeSlider1.Volume = 0.6F;
            volumeSlider1.VolumeChanged += volumeSlider1_VolumeChanged;
            // 
            // icons
            // 
            icons.ColorDepth = ColorDepth.Depth32Bit;
            icons.ImageStream = (ImageListStreamer)resources.GetObject("icons.ImageStream");
            icons.TransparentColor = Color.Transparent;
            icons.Images.SetKeyName(0, "play.png");
            icons.Images.SetKeyName(1, "pause.png");
            // 
            // btnPlay
            // 
            btnPlay.FlatAppearance.BorderColor = SystemColors.Control;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.ImageIndex = 0;
            btnPlay.ImageList = icons;
            btnPlay.Location = new Point(260, 66);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(48, 48);
            btnPlay.TabIndex = 9;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.FlatAppearance.BorderColor = SystemColors.Control;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.ImageIndex = 1;
            btnPause.ImageList = icons;
            btnPause.Location = new Point(314, 66);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(55, 48);
            btnPause.TabIndex = 10;
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // trbSeeker
            // 
            trbSeeker.Location = new Point(426, 83);
            trbSeeker.Name = "trbSeeker";
            trbSeeker.Size = new Size(321, 45);
            trbSeeker.TabIndex = 11;
            trbSeeker.TickStyle = TickStyle.None;
            trbSeeker.MouseDown += trbSeeker_MouseDown;
            trbSeeker.MouseUp += trbSeeker_MouseUp;
            // 
            // lblSeekMin
            // 
            lblSeekMin.AutoSize = true;
            lblSeekMin.Location = new Point(392, 83);
            lblSeekMin.Name = "lblSeekMin";
            lblSeekMin.Size = new Size(28, 15);
            lblSeekMin.TabIndex = 12;
            lblSeekMin.Text = "0:00";
            // 
            // lblSeekMax
            // 
            lblSeekMax.AutoSize = true;
            lblSeekMax.Location = new Point(753, 83);
            lblSeekMax.Name = "lblSeekMax";
            lblSeekMax.Size = new Size(28, 15);
            lblSeekMax.TabIndex = 13;
            lblSeekMax.Text = "0:00";
            // 
            // tmrSeekBar
            // 
            tmrSeekBar.Interval = 1;
            tmrSeekBar.Tick += tmrSeekBar_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)trbSeeker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private TreeView trvDirectories;
        private Button btnExit;
        private VolumeSlider volumeSlider1;
        private ImageList icons;
        private Button btnPlay;
        private Button btnPause;
        private TrackBar trbSeeker;
        private Label lblSeekMin;
        private Label lblSeekMax;
        private System.Windows.Forms.Timer tmrSeekBar;
    }
}