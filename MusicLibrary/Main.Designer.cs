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
            lblHeader = new Label();
            trvDirectories = new TreeView();
            btnExit = new Button();
            volumeSlider1 = new VolumeSlider();
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
            volumeSlider1.Location = new Point(301, 104);
            volumeSlider1.Margin = new Padding(4, 5, 4, 5);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new Size(94, 29);
            volumeSlider1.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(trvDirectories);
            Controls.Add(lblHeader);
            Controls.Add(volumeSlider1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private TreeView trvDirectories;
        private Button btnExit;
        private VolumeSlider volumeSlider1;
    }
}