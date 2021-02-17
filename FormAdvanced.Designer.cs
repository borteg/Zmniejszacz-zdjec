
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
            this.changedQuality = new System.Windows.Forms.ComboBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.UserMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.UserMaxWidth = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelQuality = new System.Windows.Forms.Label();
            this.groupBoxQuality = new System.Windows.Forms.GroupBox();
            this.groupBoxInstall = new System.Windows.Forms.GroupBox();
            this.labelAdminInfo = new System.Windows.Forms.Label();
            this.groupBoxResolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserMaxWidth)).BeginInit();
            this.groupBoxQuality.SuspendLayout();
            this.groupBoxInstall.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(27, 238);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(73, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Zatwierdź";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 238);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.changedQuality.Location = new System.Drawing.Point(16, 51);
            this.changedQuality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changedQuality.Name = "changedQuality";
            this.changedQuality.Size = new System.Drawing.Size(82, 21);
            this.changedQuality.TabIndex = 5;
            this.changedQuality.SelectedIndexChanged += new System.EventHandler(this.changedQuality_SelectedIndexChanged);
            // 
            // btnInstall
            // 
            this.btnInstall.Enabled = false;
            this.btnInstall.Location = new System.Drawing.Point(33, 52);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(80, 23);
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
            this.groupBoxResolution.Location = new System.Drawing.Point(11, 8);
            this.groupBoxResolution.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResolution.Size = new System.Drawing.Size(99, 110);
            this.groupBoxResolution.TabIndex = 8;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.Text = "Maks. wymiary";
            // 
            // UserMaxHeight
            // 
            this.UserMaxHeight.Location = new System.Drawing.Point(10, 74);
            this.UserMaxHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.UserMaxHeight.Size = new System.Drawing.Size(80, 20);
            this.UserMaxHeight.TabIndex = 6;
            this.UserMaxHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserMaxHeight.ValueChanged += new System.EventHandler(this.UserMaxHeight_ValueChanged);
            // 
            // UserMaxWidth
            // 
            this.UserMaxWidth.Location = new System.Drawing.Point(10, 34);
            this.UserMaxWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.UserMaxWidth.Size = new System.Drawing.Size(80, 20);
            this.UserMaxWidth.TabIndex = 4;
            this.UserMaxWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserMaxWidth.ValueChanged += new System.EventHandler(this.UserMaxWidth_ValueChanged);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(9, 59);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(57, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Wysokość";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(9, 19);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(57, 13);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Szerokość";
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(15, 35);
            this.labelQuality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(58, 13);
            this.labelQuality.TabIndex = 9;
            this.labelQuality.Text = "Jakość (%)";
            // 
            // groupBoxQuality
            // 
            this.groupBoxQuality.Controls.Add(this.labelQuality);
            this.groupBoxQuality.Controls.Add(this.changedQuality);
            this.groupBoxQuality.Location = new System.Drawing.Point(121, 8);
            this.groupBoxQuality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxQuality.Name = "groupBoxQuality";
            this.groupBoxQuality.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxQuality.Size = new System.Drawing.Size(115, 110);
            this.groupBoxQuality.TabIndex = 10;
            this.groupBoxQuality.TabStop = false;
            this.groupBoxQuality.Text = "Jakość";
            // 
            // groupBoxInstall
            // 
            this.groupBoxInstall.Controls.Add(this.labelAdminInfo);
            this.groupBoxInstall.Controls.Add(this.btnInstall);
            this.groupBoxInstall.Location = new System.Drawing.Point(50, 130);
            this.groupBoxInstall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInstall.Name = "groupBoxInstall";
            this.groupBoxInstall.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInstall.Size = new System.Drawing.Size(147, 88);
            this.groupBoxInstall.TabIndex = 11;
            this.groupBoxInstall.TabStop = false;
            this.groupBoxInstall.Text = "Instalacja";
            // 
            // labelAdminInfo
            // 
            this.labelAdminInfo.ForeColor = System.Drawing.Color.Red;
            this.labelAdminInfo.Location = new System.Drawing.Point(12, 19);
            this.labelAdminInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelAdminInfo.Name = "labelAdminInfo";
            this.labelAdminInfo.Size = new System.Drawing.Size(123, 26);
            this.labelAdminInfo.TabIndex = 8;
            this.labelAdminInfo.Text = "Wymagane uprawnienia administratora";
            this.labelAdminInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(249, 282);
            this.Controls.Add(this.groupBoxInstall);
            this.Controls.Add(this.groupBoxQuality);
            this.Controls.Add(this.groupBoxResolution);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdvanced";
            this.Text = "Zaawansowane";
            this.Load += new System.EventHandler(this.FormAdvanced_Load);
            this.groupBoxResolution.ResumeLayout(false);
            this.groupBoxResolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserMaxWidth)).EndInit();
            this.groupBoxQuality.ResumeLayout(false);
            this.groupBoxQuality.PerformLayout();
            this.groupBoxInstall.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox changedQuality;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.GroupBox groupBoxResolution;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.GroupBox groupBoxQuality;
        private System.Windows.Forms.GroupBox groupBoxInstall;
        private System.Windows.Forms.Label labelAdminInfo;
        private System.Windows.Forms.NumericUpDown UserMaxHeight;
        private System.Windows.Forms.NumericUpDown UserMaxWidth;
    }
}