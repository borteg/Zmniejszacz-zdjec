namespace Zmniejszacz_zdjęć
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.previewPic = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.overwriteCheck = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.clrButton = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.groupBoxPictures = new System.Windows.Forms.GroupBox();
            this.groupBoxSave = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPic)).BeginInit();
            this.groupBoxPictures.SuspendLayout();
            this.groupBoxSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewPic
            // 
            this.previewPic.BackColor = System.Drawing.Color.Gray;
            this.previewPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previewPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.previewPic.Location = new System.Drawing.Point(225, 16);
            this.previewPic.Name = "previewPic";
            this.previewPic.Size = new System.Drawing.Size(347, 332);
            this.previewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPic.TabIndex = 0;
            this.previewPic.TabStop = false;
            this.previewPic.Click += new System.EventHandler(this.previewPic_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(14, 25);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Dodaj";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(60, 45);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // imgList
            // 
            this.imgList.FormattingEnabled = true;
            this.imgList.HorizontalScrollbar = true;
            this.imgList.Location = new System.Drawing.Point(14, 60);
            this.imgList.Name = "imgList";
            this.imgList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.imgList.Size = new System.Drawing.Size(170, 95);
            this.imgList.TabIndex = 3;
            this.imgList.SelectedIndexChanged += new System.EventHandler(this.imgList_SelectedIndexChanged);
            this.imgList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.imgList_DeletePressed);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(35, 78);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(125, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 4;
            // 
            // overwriteCheck
            // 
            this.overwriteCheck.AutoSize = true;
            this.overwriteCheck.Checked = true;
            this.overwriteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteCheck.ForeColor = System.Drawing.Color.Red;
            this.overwriteCheck.Location = new System.Drawing.Point(67, 21);
            this.overwriteCheck.Name = "overwriteCheck";
            this.overwriteCheck.Size = new System.Drawing.Size(64, 17);
            this.overwriteCheck.TabIndex = 5;
            this.overwriteCheck.Text = "Nadpisz";
            this.overwriteCheck.UseVisualStyleBackColor = true;
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(109, 25);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(75, 23);
            this.clrButton.TabIndex = 7;
            this.clrButton.Text = "Wyczyść";
            this.clrButton.UseMnemonic = false;
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(62, 199);
            this.btnAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(93, 23);
            this.btnAdvanced.TabIndex = 8;
            this.btnAdvanced.Text = "Zaawansowane";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // groupBoxPictures
            // 
            this.groupBoxPictures.Controls.Add(this.addBtn);
            this.groupBoxPictures.Controls.Add(this.clrButton);
            this.groupBoxPictures.Controls.Add(this.imgList);
            this.groupBoxPictures.Location = new System.Drawing.Point(11, 10);
            this.groupBoxPictures.Name = "groupBoxPictures";
            this.groupBoxPictures.Size = new System.Drawing.Size(200, 175);
            this.groupBoxPictures.TabIndex = 9;
            this.groupBoxPictures.TabStop = false;
            this.groupBoxPictures.Text = "Zdjęcia";
            // 
            // groupBoxSave
            // 
            this.groupBoxSave.Controls.Add(this.progressBar);
            this.groupBoxSave.Controls.Add(this.saveBtn);
            this.groupBoxSave.Controls.Add(this.overwriteCheck);
            this.groupBoxSave.Location = new System.Drawing.Point(11, 232);
            this.groupBoxSave.Name = "groupBoxSave";
            this.groupBoxSave.Size = new System.Drawing.Size(200, 116);
            this.groupBoxSave.TabIndex = 8;
            this.groupBoxSave.TabStop = false;
            this.groupBoxSave.Text = "Zapisywanie";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.groupBoxSave);
            this.Controls.Add(this.groupBoxPictures);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.previewPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Zmniejszacz Zdjęć";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.previewPic)).EndInit();
            this.groupBoxPictures.ResumeLayout(false);
            this.groupBoxSave.ResumeLayout(false);
            this.groupBoxSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPic;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox imgList;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox overwriteCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.GroupBox groupBoxPictures;
        private System.Windows.Forms.GroupBox groupBoxSave;
    }
}

