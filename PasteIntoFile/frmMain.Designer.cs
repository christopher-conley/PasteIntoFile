namespace PasteAsFile
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblType = new System.Windows.Forms.Label();
            imgContent = new System.Windows.Forms.PictureBox();
            txtContent = new System.Windows.Forms.TextBox();
            lblFileName = new System.Windows.Forms.Label();
            txtFilename = new System.Windows.Forms.TextBox();
            lblExt = new System.Windows.Forms.Label();
            comExt = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            txtCurrentLocation = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnBrowseForFolder = new System.Windows.Forms.Button();
            lblMe = new System.Windows.Forms.Label();
            lblWebsite = new System.Windows.Forms.Label();
            lblHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)imgContent).BeginInit();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new System.Drawing.Point(17, 160);
            lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(40, 20);
            lblType.TabIndex = 6;
            lblType.Text = "Type";
            // 
            // imgContent
            // 
            imgContent.Location = new System.Drawing.Point(275, 362);
            imgContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            imgContent.Name = "imgContent";
            imgContent.Size = new System.Drawing.Size(161, 125);
            imgContent.TabIndex = 2;
            imgContent.TabStop = false;
            // 
            // txtContent
            // 
            txtContent.Location = new System.Drawing.Point(16, 362);
            txtContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtContent.Size = new System.Drawing.Size(249, 176);
            txtContent.TabIndex = 3;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new System.Drawing.Point(17, 20);
            lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new System.Drawing.Size(76, 20);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "Filename :";
            // 
            // txtFilename
            // 
            txtFilename.Location = new System.Drawing.Point(21, 46);
            txtFilename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtFilename.Name = "txtFilename";
            txtFilename.Size = new System.Drawing.Size(244, 27);
            txtFilename.TabIndex = 1;
            txtFilename.KeyPress += txtFilename_KeyPress;
            // 
            // lblExt
            // 
            lblExt.AutoSize = true;
            lblExt.Location = new System.Drawing.Point(312, 20);
            lblExt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExt.Name = "lblExt";
            lblExt.Size = new System.Drawing.Size(79, 20);
            lblExt.TabIndex = 6;
            lblExt.Text = "Extension :";
            // 
            // comExt
            // 
            comExt.FormattingEnabled = true;
            comExt.Items.AddRange(new object[] { "txt", "html", "js", "css", "csv", "json", "cs", "cpp", "java", "php", "png", "jpg", "bmp", "gif", "ico" });
            comExt.Location = new System.Drawing.Point(316, 46);
            comExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            comExt.Name = "comExt";
            comExt.Size = new System.Drawing.Size(96, 28);
            comExt.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            btnSave.Location = new System.Drawing.Point(144, 146);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(180, 46);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCurrentLocation
            // 
            txtCurrentLocation.Location = new System.Drawing.Point(21, 111);
            txtCurrentLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCurrentLocation.Name = "txtCurrentLocation";
            txtCurrentLocation.Size = new System.Drawing.Size(339, 27);
            txtCurrentLocation.TabIndex = 3;
            txtCurrentLocation.Text = "D:\\";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 85);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 20);
            label1.TabIndex = 9;
            label1.Text = "Current Location :";
            // 
            // btnBrowseForFolder
            // 
            btnBrowseForFolder.Location = new System.Drawing.Point(369, 108);
            btnBrowseForFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnBrowseForFolder.Name = "btnBrowseForFolder";
            btnBrowseForFolder.Size = new System.Drawing.Size(44, 35);
            btnBrowseForFolder.TabIndex = 4;
            btnBrowseForFolder.Text = "...";
            btnBrowseForFolder.UseVisualStyleBackColor = true;
            btnBrowseForFolder.Click += btnBrowseForFolder_Click;
            // 
            // lblMe
            // 
            lblMe.AutoSize = true;
            lblMe.ForeColor = System.Drawing.Color.Gray;
            lblMe.Location = new System.Drawing.Point(267, 206);
            lblMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMe.Name = "lblMe";
            lblMe.Size = new System.Drawing.Size(171, 20);
            lblMe.TabIndex = 12;
            lblMe.Text = "© Eslam Hamouda 2014";
            lblMe.Click += lblMe_Click;
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.ForeColor = System.Drawing.Color.Gray;
            lblWebsite.Location = new System.Drawing.Point(16, 206);
            lblWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new System.Drawing.Size(87, 20);
            lblWebsite.TabIndex = 13;
            lblWebsite.Text = "eslamx.com";
            lblWebsite.Click += lblWebsite_Click;
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Cursor = System.Windows.Forms.Cursors.Help;
            lblHelp.Font = new System.Drawing.Font("Tahoma", 10F);
            lblHelp.Location = new System.Drawing.Point(393, 158);
            lblHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new System.Drawing.Size(18, 21);
            lblHelp.TabIndex = 8;
            lblHelp.Text = "?";
            lblHelp.Click += lblHelp_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(445, 240);
            Controls.Add(lblHelp);
            Controls.Add(lblWebsite);
            Controls.Add(lblMe);
            Controls.Add(btnBrowseForFolder);
            Controls.Add(txtCurrentLocation);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(comExt);
            Controls.Add(lblExt);
            Controls.Add(txtFilename);
            Controls.Add(lblFileName);
            Controls.Add(txtContent);
            Controls.Add(imgContent);
            Controls.Add(lblType);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Paste Into File";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)imgContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox imgContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.ComboBox comExt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCurrentLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseForFolder;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblHelp;
    }
}

