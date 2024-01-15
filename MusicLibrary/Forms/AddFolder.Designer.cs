namespace MusicLibrary_GUI
{
    partial class AddFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFolder));
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnChooseDirectory = new Button();
            img_icons = new ImageList(components);
            txtFilePath = new TextBox();
            lblFindArtist = new Label();
            txtFindArtist = new TextBox();
            lblAlbumName = new Label();
            btnFindArtist = new Button();
            cmbArtist = new ComboBox();
            cmbAlbum = new ComboBox();
            rdEP = new RadioButton();
            rdAlbum = new RadioButton();
            rdSingle = new RadioButton();
            grpReleaseType = new GroupBox();
            btnAddAlbum = new Button();
            grpReleaseType.SuspendLayout();
            SuspendLayout();
            // 
            // btnChooseDirectory
            // 
            btnChooseDirectory.FlatAppearance.BorderColor = SystemColors.Control;
            btnChooseDirectory.ImageIndex = 0;
            btnChooseDirectory.ImageList = img_icons;
            btnChooseDirectory.Location = new Point(541, 40);
            btnChooseDirectory.Margin = new Padding(4, 5, 4, 5);
            btnChooseDirectory.Name = "btnChooseDirectory";
            btnChooseDirectory.Size = new Size(44, 35);
            btnChooseDirectory.TabIndex = 0;
            btnChooseDirectory.UseVisualStyleBackColor = true;
            btnChooseDirectory.Click += btnChooseDirectory_Click;
            // 
            // img_icons
            // 
            img_icons.ColorDepth = ColorDepth.Depth32Bit;
            img_icons.ImageStream = (ImageListStreamer)resources.GetObject("img_icons.ImageStream");
            img_icons.TransparentColor = Color.Transparent;
            img_icons.Images.SetKeyName(0, "three_dots.png");
            // 
            // txtFilePath
            // 
            txtFilePath.Enabled = false;
            txtFilePath.Location = new Point(54, 41);
            txtFilePath.Margin = new Padding(4, 5, 4, 5);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(478, 30);
            txtFilePath.TabIndex = 1;
            // 
            // lblFindArtist
            // 
            lblFindArtist.AutoSize = true;
            lblFindArtist.Location = new Point(54, 135);
            lblFindArtist.Margin = new Padding(4, 0, 4, 0);
            lblFindArtist.Name = "lblFindArtist";
            lblFindArtist.Size = new Size(87, 23);
            lblFindArtist.TabIndex = 2;
            lblFindArtist.Text = "Find Artist";
            // 
            // txtFindArtist
            // 
            txtFindArtist.Location = new Point(171, 134);
            txtFindArtist.Name = "txtFindArtist";
            txtFindArtist.Size = new Size(143, 30);
            txtFindArtist.TabIndex = 3;
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.Location = new Point(54, 194);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(111, 23);
            lblAlbumName.TabIndex = 5;
            lblAlbumName.Text = "Album Name";
            // 
            // btnFindArtist
            // 
            btnFindArtist.Location = new Point(336, 135);
            btnFindArtist.Name = "btnFindArtist";
            btnFindArtist.Size = new Size(93, 30);
            btnFindArtist.TabIndex = 6;
            btnFindArtist.Text = "Find";
            btnFindArtist.UseVisualStyleBackColor = true;
            btnFindArtist.Click += btnFindArtist_Click;
            // 
            // cmbArtist
            // 
            cmbArtist.FormattingEnabled = true;
            cmbArtist.Location = new Point(453, 134);
            cmbArtist.Name = "cmbArtist";
            cmbArtist.Size = new Size(258, 31);
            cmbArtist.TabIndex = 8;
            cmbArtist.SelectedValueChanged += cmbArtist_SelectedValueChanged;
            // 
            // cmbAlbum
            // 
            cmbAlbum.FormattingEnabled = true;
            cmbAlbum.Location = new Point(171, 191);
            cmbAlbum.Name = "cmbAlbum";
            cmbAlbum.Size = new Size(258, 31);
            cmbAlbum.TabIndex = 9;
            // 
            // rdEP
            // 
            rdEP.AutoSize = true;
            rdEP.Location = new Point(18, 29);
            rdEP.Name = "rdEP";
            rdEP.Size = new Size(47, 27);
            rdEP.TabIndex = 10;
            rdEP.Text = "EP";
            rdEP.UseVisualStyleBackColor = true;
            rdEP.CheckedChanged += RdioReleaseType_CheckChanged;
            // 
            // rdAlbum
            // 
            rdAlbum.AutoSize = true;
            rdAlbum.Checked = true;
            rdAlbum.Location = new Point(18, 62);
            rdAlbum.Name = "rdAlbum";
            rdAlbum.Size = new Size(78, 27);
            rdAlbum.TabIndex = 11;
            rdAlbum.TabStop = true;
            rdAlbum.Text = "Album";
            rdAlbum.UseVisualStyleBackColor = true;
            rdAlbum.CheckedChanged += RdioReleaseType_CheckChanged;
            // 
            // rdSingle
            // 
            rdSingle.AutoSize = true;
            rdSingle.Location = new Point(18, 95);
            rdSingle.Name = "rdSingle";
            rdSingle.Size = new Size(74, 27);
            rdSingle.TabIndex = 12;
            rdSingle.Text = "Single";
            rdSingle.UseVisualStyleBackColor = true;
            rdSingle.CheckedChanged += RdioReleaseType_CheckChanged;
            // 
            // grpReleaseType
            // 
            grpReleaseType.Controls.Add(rdSingle);
            grpReleaseType.Controls.Add(rdAlbum);
            grpReleaseType.Controls.Add(rdEP);
            grpReleaseType.Location = new Point(516, 185);
            grpReleaseType.Name = "grpReleaseType";
            grpReleaseType.Size = new Size(153, 140);
            grpReleaseType.TabIndex = 13;
            grpReleaseType.TabStop = false;
            grpReleaseType.Text = "Release Type";
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.Location = new Point(54, 251);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(102, 56);
            btnAddAlbum.TabIndex = 14;
            btnAddAlbum.Text = "Add Album";
            btnAddAlbum.UseVisualStyleBackColor = true;
            btnAddAlbum.Click += btnAddAlbum_Click;
            // 
            // AddFolder
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 330);
            Controls.Add(btnAddAlbum);
            Controls.Add(grpReleaseType);
            Controls.Add(cmbAlbum);
            Controls.Add(cmbArtist);
            Controls.Add(btnFindArtist);
            Controls.Add(lblAlbumName);
            Controls.Add(txtFindArtist);
            Controls.Add(lblFindArtist);
            Controls.Add(txtFilePath);
            Controls.Add(btnChooseDirectory);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddFolder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFolder";
            Load += AddFolder_Load;
            grpReleaseType.ResumeLayout(false);
            grpReleaseType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnChooseDirectory;
        private ImageList img_icons;
        private TextBox txtFilePath;
        private Label lblFindArtist;
        private TextBox txtFindArtist;
        private TextBox txtFindAlbum;
        private Label lblAlbumName;
        private Button btnFindArtist;
        private Button btnFindAlbum;
        private ComboBox cmbArtist;
        private ComboBox cmbAlbum;
        private RadioButton rdEP;
        private RadioButton rdAlbum;
        private RadioButton rdSingle;
        private GroupBox grpReleaseType;
        private Button btnAddAlbum;
    }
}