using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Zmniejszacz_zdjęć
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeFileDialog();
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach(string file in files)
            {
                if(ImageHandler.isImage(file))
                {
                    FileHandler.AddFile(file);
                }
            }

            RefreshIMGList();
        }

        private void InitializeFileDialog()
        {
            this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFileDialog.Filter = "Zdjęcia (*.bmp; *.jpg; *.jpeg; *.gif)|*.bmp; *.jpg; *.jpeg; *.gif|Wszystkie pliki (*.*)|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
        }

        private void RefreshIMGList()
        {
            this.imgList.Items.Clear();

            int i = 0;

            foreach (string file in FileHandler.ReadFiles())
            {

                i++;
                this.imgList.Items.Add(i + "." + Path.GetFileName(file));
            }
        }

        private bool ResizeAndSave()
        {
            Bitmap image;

            progressBar.Maximum = imgList.Items.Count;

            if (overwriteCheck.Checked)
            {
                foreach (string file in FileHandler.ReadFiles())
                {
                    image = ImageHandler.Resize(file);

                    ImageHandler.Save(image, file);

                    progressBar.PerformStep();
                }
            }

            else
            {
                if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string newPath = folderBrowserDialog.SelectedPath;

                    foreach (string file in FileHandler.ReadFiles())
                    {
                        image = ImageHandler.Resize(file);

                        ImageHandler.Save(image, Path.Combine(newPath, Path.GetFileName(file)));

                        progressBar.PerformStep();
                    }
                }
            }

            return true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK);
            {
                foreach (string file in this.openFileDialog.FileNames)
                {
                    if (ImageHandler.isImage(file))
                    {
                        FileHandler.AddFile(file);
                    }
                }

                RefreshIMGList();
            }
        }

        private void imgList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.imgList.SelectedIndex != -1)
            {
                try
                {
                    if(this.previewPic.Image != null)
                    {
                        this.previewPic.Image.Dispose();
                    }

                    this.previewPic.Image = Image.FromFile(FileHandler.ReadFiles()[this.imgList.SelectedIndex]);
                }

                catch (FileNotFoundException)
                {
                    MessageBox.Show("Nie znaleziono pliku: " + FileHandler.ReadFiles()[this.imgList.SelectedIndex]);

                    FileHandler.RemoveFile(this.imgList.SelectedIndex);
                    RefreshIMGList();
                }

                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Nieprawidłowy format pliku: " + FileHandler.ReadFiles()[this.imgList.SelectedIndex]);

                    FileHandler.RemoveFile(this.imgList.SelectedIndex);
                    RefreshIMGList();
                }
            }
        }

        private void imgList_DeletePressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete && this.imgList.SelectedIndex != -1)
            {
                FileHandler.RemoveFile(this.imgList.SelectedIndex);

                RefreshIMGList();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(ResizeAndSave())
            {
                MessageBox.Show("Zmniejszono i zapisano pomyślnie");
            }

            progressBar.Value = 0;
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            if(imgList.Items.Count > 0)
            {
                FileHandler.ClearFiles();

                RefreshIMGList();
            }
        }
    }
}
