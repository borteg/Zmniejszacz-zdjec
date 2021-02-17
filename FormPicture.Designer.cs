namespace Zmniejszacz_zdjęć
{
    partial class FormPicture
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
            this.previewPicForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicForm)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPicForm
            // 
            this.previewPicForm.Location = new System.Drawing.Point(0, 0);
            this.previewPicForm.Margin = new System.Windows.Forms.Padding(0);
            this.previewPicForm.Name = "previewPicForm";
            this.previewPicForm.Size = new System.Drawing.Size(894, 661);
            this.previewPicForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPicForm.TabIndex = 0;
            this.previewPicForm.TabStop = false;
            // 
            // FormPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(894, 661);
            this.Controls.Add(this.previewPicForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPicture";
            this.Text = "Podgląd";
            ((System.ComponentModel.ISupportInitialize)(this.previewPicForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPicForm;
    }
}