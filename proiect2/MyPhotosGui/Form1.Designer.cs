namespace MyPhotosGui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnAddMedia = new System.Windows.Forms.Button();
            this.BtnVideos = new System.Windows.Forms.Button();
            this.BtnPhotos = new System.Windows.Forms.Button();
            this.comboBoxAtr = new System.Windows.Forms.ComboBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.TextBoxResDesc = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayerMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.PanelLeft.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.PanelLeft.Controls.Add(this.BtnDelete);
            this.PanelLeft.Controls.Add(this.BtnAll);
            this.PanelLeft.Controls.Add(this.BtnAddMedia);
            this.PanelLeft.Controls.Add(this.BtnVideos);
            this.PanelLeft.Controls.Add(this.BtnPhotos);
            this.PanelLeft.Controls.Add(this.comboBoxAtr);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(200, 708);
            this.PanelLeft.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDelete.Location = new System.Drawing.Point(0, 568);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnDelete.Size = new System.Drawing.Size(200, 70);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete Selected";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAll.FlatAppearance.BorderSize = 0;
            this.BtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAll.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAll.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAll.Location = new System.Drawing.Point(0, 177);
            this.BtnAll.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnAll.Size = new System.Drawing.Size(200, 70);
            this.BtnAll.TabIndex = 4;
            this.BtnAll.Text = "All";
            this.BtnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnAddMedia
            // 
            this.BtnAddMedia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAddMedia.FlatAppearance.BorderSize = 0;
            this.BtnAddMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddMedia.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMedia.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAddMedia.Location = new System.Drawing.Point(0, 638);
            this.BtnAddMedia.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddMedia.Name = "BtnAddMedia";
            this.BtnAddMedia.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnAddMedia.Size = new System.Drawing.Size(200, 70);
            this.BtnAddMedia.TabIndex = 3;
            this.BtnAddMedia.Text = "Add Media";
            this.BtnAddMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddMedia.UseVisualStyleBackColor = true;
            this.BtnAddMedia.Click += new System.EventHandler(this.BtnAddMedia_Click);
            // 
            // BtnVideos
            // 
            this.BtnVideos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVideos.FlatAppearance.BorderSize = 0;
            this.BtnVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVideos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVideos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVideos.Location = new System.Drawing.Point(0, 107);
            this.BtnVideos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVideos.Name = "BtnVideos";
            this.BtnVideos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnVideos.Size = new System.Drawing.Size(200, 70);
            this.BtnVideos.TabIndex = 2;
            this.BtnVideos.Text = "Videos";
            this.BtnVideos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVideos.UseVisualStyleBackColor = true;
            this.BtnVideos.Click += new System.EventHandler(this.BtnVideos_Click);
            // 
            // BtnPhotos
            // 
            this.BtnPhotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPhotos.FlatAppearance.BorderSize = 0;
            this.BtnPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPhotos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPhotos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPhotos.Location = new System.Drawing.Point(0, 37);
            this.BtnPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPhotos.Name = "BtnPhotos";
            this.BtnPhotos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnPhotos.Size = new System.Drawing.Size(200, 70);
            this.BtnPhotos.TabIndex = 1;
            this.BtnPhotos.Text = "Photos";
            this.BtnPhotos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPhotos.UseVisualStyleBackColor = true;
            this.BtnPhotos.Click += new System.EventHandler(this.BtnPhotos_Click);
            // 
            // comboBoxAtr
            // 
            this.comboBoxAtr.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxAtr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAtr.Font = new System.Drawing.Font("Calibri", 18F);
            this.comboBoxAtr.FormattingEnabled = true;
            this.comboBoxAtr.Location = new System.Drawing.Point(0, 0);
            this.comboBoxAtr.Name = "comboBoxAtr";
            this.comboBoxAtr.Size = new System.Drawing.Size(200, 37);
            this.comboBoxAtr.TabIndex = 0;
            this.comboBoxAtr.Text = "atributes";
            // 
            // PanelBottom
            // 
            this.PanelBottom.AutoScroll = true;
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(200, 447);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1171, 261);
            this.PanelBottom.TabIndex = 1;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelTop.Controls.Add(this.TextBoxSearch);
            this.PanelTop.Controls.Add(this.BtnSearch);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(200, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1171, 38);
            this.PanelTop.TabIndex = 2;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxSearch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(1001, 40);
            this.TextBoxSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(1001, 0);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(170, 38);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(322, 75);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(352, 299);
            this.pictureBoxMain.TabIndex = 3;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Tag = "";
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBoxMain_Click);
            // 
            // TextBoxResDesc
            // 
            this.TextBoxResDesc.Location = new System.Drawing.Point(726, 200);
            this.TextBoxResDesc.Multiline = true;
            this.TextBoxResDesc.Name = "TextBoxResDesc";
            this.TextBoxResDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxResDesc.Size = new System.Drawing.Size(390, 174);
            this.TextBoxResDesc.TabIndex = 4;
            // 
            // axWindowsMediaPlayerMain
            // 
            this.axWindowsMediaPlayerMain.Enabled = true;
            this.axWindowsMediaPlayerMain.Location = new System.Drawing.Point(322, 75);
            this.axWindowsMediaPlayerMain.Name = "axWindowsMediaPlayerMain";
            this.axWindowsMediaPlayerMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMain.OcxState")));
            this.axWindowsMediaPlayerMain.Size = new System.Drawing.Size(352, 299);
            this.axWindowsMediaPlayerMain.TabIndex = 5;
            this.axWindowsMediaPlayerMain.Enter += new System.EventHandler(this.axWindowsMediaPlayerMain_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 708);
            this.Controls.Add(this.axWindowsMediaPlayerMain);
            this.Controls.Add(this.TextBoxResDesc);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLeft.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button BtnVideos;
        private System.Windows.Forms.Button BtnPhotos;
        private System.Windows.Forms.ComboBox comboBoxAtr;
        private System.Windows.Forms.Button BtnAddMedia;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.TextBox TextBoxResDesc;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMain;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnDelete;
    }
}

