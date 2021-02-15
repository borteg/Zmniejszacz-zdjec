
namespace Zmniejszacz_zdjęć
{
    partial class FormAdvanced
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkConvert = new System.Windows.Forms.CheckBox();
            this.changedQuality = new System.Windows.Forms.ComboBox();
            this.changedFormat = new System.Windows.Forms.ComboBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelQuality = new System.Windows.Forms.Label();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.groupBoxInstall = new System.Windows.Forms.GroupBox();
            this.labelAdminInfo = new System.Windows.Forms.Label();
            this.UserMaxWidth = new System.Windows.Forms.NumericUpDown();
            this.UserMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.groupBoxResolution.SuspendLayout();
            this.groupBoxFormat.SuspendLayout();
            this.groupBoxInstall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserMaxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserMaxHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(40, 366);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(110, 35);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Zatwierdź";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkConvert
            // 
            this.checkConvert.AutoSize = true;
            this.checkConvert.Location = new System.Drawing.Point(34, 87);
            this.checkConvert.Name = "checkConvert";
            this.checkConvert.Size = new System.Drawing.Size(105, 24);
            this.checkConvert.TabIndex = 4;
            this.checkConvert.Text = "Konwertuj";
            this.checkConvert.UseVisualStyleBackColor = true;
            this.checkConvert.CheckedChanged += new System.EventHandler(this.checkConvert_CheckedChanged);
            // 
            // changedQuality
            // 
            this.changedQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changedQuality.FormattingEnabled = true;
            this.changedQuality.Items.AddRange(new object[] {
            "100",
            "95",
            "90",
            "85",
            "80",
            "75",
            "70",
            "65",
            "60",
            "55",
            "50",
            "45",
            "40",
            "35",
            "30",
            "25",
            "20",
            "15",
            "10",
            "5"});
            this.changedQuality.Location = new System.Drawing.Point(26, 52);
            this.changedQuality.Name = "changedQuality";
            this.changedQuality.Size = new System.Drawing.Size(121, 28);
            this.changedQuality.TabIndex = 5;
            this.changedQuality.SelectedIndexChanged += new System.EventHandler(this.changedQuality_SelectedIndexChanged);
            // 
            // changedFormat
            // 
            this.changedFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changedFormat.Enabled = false;
            this.changedFormat.FormattingEnabled = true;
            this.changedFormat.Items.AddRange(new object[] {
            "BMP",
            "GIF",
            "JPEG",
            "PNG",
            "TIFF"});
            this.changedFormat.Location = new System.Drawing.Point(26, 115);
            this.changedFormat.Name = "changedFormat";
            this.changedFormat.Size = new System.Drawing.Size(121, 28);
            this.changedFormat.TabIndex = 6;
            // 
            // btnInstall
            // 
            this.btnInstall.Enabled = false;
            this.btnInstall.Location = new System.Drawing.Point(50, 80);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(120, 35);
            this.btnInstall.TabIndex = 7;
            this.btnInstall.Text = "Instaluj";
            this.btnInstall.UseVisualStyleBackColor = true;
            // 
            // groupBoxResolution
            // 
            this.groupBoxResolution.Controls.Add(this.UserMaxHeight);
            this.groupBoxResolution.Controls.Add(this.UserMaxWidth);
            this.groupBoxResolution.Controls.Add(this.labelHeight);
            this.groupBoxResolution.Controls.Add(this.labelWidth);
            this.groupBoxResolution.Location = new System.Drawing.Point(17, 12);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Size = new System.Drawing.Size(148, 170);
            this.groupBoxResolution.TabIndex = 8;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.Text = "Maks. wymiary";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(14, 91);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(81, 20);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Wysokość";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(14, 30);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(84, 20);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Szerokość";
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(25, 30);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(59, 20);
            this.labelQuality.TabIndex = 9;
            this.labelQuality.Text = "Jakość";
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Controls.Add(this.changedFormat);
            this.groupBoxFormat.Controls.Add(this.labelQuality);
            this.groupBoxFormat.Controls.Add(this.changedQuality);
            this.groupBoxFormat.Controls.Add(this.checkConvert);
            this.groupBoxFormat.Location = new System.Drawing.Point(182, 12);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(173, 170);
            this.groupBoxFormat.TabIndex = 10;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Format";
            // 
            // groupBoxInstall
            // 
            this.groupBoxInstall.Controls.Add(this.labelAdminInfo);
            this.groupBoxInstall.Controls.Add(this.btnInstall);
            this.groupBoxInstall.Location = new System.Drawing.Point(75, 200);
            this.groupBoxInstall.Name = "groupBoxInstall";
            this.groupBoxInstall.Size = new System.Drawing.Size(220, 135);
            this.groupBoxInstall.TabIndex = 11;
            this.groupBoxInstall.TabStop = false;
            this.groupBoxInstall.Text = "Instalacja";
            // 
            // labelAdminInfo
            // 
            this.labelAdminInfo.ForeColor = System.Drawing.Color.Red;
            this.labelAdminInfo.Location = new System.Drawing.Point(18, 30);
            this.labelAdminInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelAdminInfo.Name = "labelAdminInfo";
            this.labelAdminInfo.Size = new System.Drawing.Size(185, 40);
            this.labelAdminInfo.TabIndex = 8;
            this.labelAdminInfo.Text = "Wymagane uprawnienia administratora";
            this.labelAdminInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserMaxWidth
            // 
            this.UserMaxWidth.Location = new System.Drawing.Point(15, 53);
            this.UserMaxWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.UserMaxWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserMaxWidth.Name = "UserMaxWidth";
            this.UserMaxWidth.Size = new System.Drawing.Size(120, 26);
            this.UserMaxWidth.TabIndex = 4;
            this.UserMaxWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserMaxWidth.ValueChanged += new System.EventHandler(this.UserMaxWidth_ValueChanged);
            // 
            // UserMaxHeight
            // 
            this.UserMaxHeight.Location = new System.Drawing.Point(15, 114);
            this.UserMaxHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.UserMaxHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserMaxHeight.Name = "UserMaxHeight";
            this.UserMaxHeight.Size = new System.Drawing.Size(120, 26);
            this.UserMaxHeight.TabIndex = 6;
            this.UserMaxHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserMaxHeight.ValueChanged += new System.EventHandler(this.UserMaxHeight_ValueChanged);
            // 
            // FormAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 434);
            this.Controls.Add(this.groupBoxInstall);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.groupBoxResolution);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdvanced";
            this.Text = "Zaawansowane";
            this.Load += new System.EventHandler(this.FormAdvanced_Load);
            this.groupBoxResolution.ResumeLayout(false);
            this.groupBoxResolution.PerformLayout();
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.groupBoxInstall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserMaxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserMaxHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkConvert;
        private System.Windows.Forms.ComboBox changedQuality;
        private System.Windows.Forms.ComboBox changedFormat;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.GroupBox groupBoxResolution;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.GroupBox groupBoxInstall;
        private System.Windows.Forms.Label labelAdminInfo;
        private System.Windows.Forms.NumericUpDown UserMaxHeight;
        private System.Windows.Forms.NumericUpDown UserMaxWidth;
    }
}