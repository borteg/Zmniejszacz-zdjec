using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Printing;

namespace Zmniejszacz_zdjęć
{
    public partial class FormMain : Form
    {
        private MemoryStream stream = new MemoryStream();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeFileDialog();

            saveBtn.Enabled = false;

            FileHandler.ReadFiles().CollectionChanged += RefreshIMGList;
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
                if(ImageHandler.isJpeg(file) && FileHandler.NotDuplicate(file))
                {
                    FileHandler.AddFile(file);
                }
            }
        }

        private void InitializeFileDialog()
        {
            this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFileDialog.Filter = "Zdjęcia (*.jpg; *.jpeg)|*.jpg; *.jpeg|Wszystkie pliki (*.*)|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
        }

        private void RefreshIMGList(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.imgList.Items.Clear();

            previewPic.Image = null;
            previewPic.Cursor = Cursors.Default;

            int i = 0;

            foreach (string file in FileHandler.ReadFiles())
            {

                i++;
                this.imgList.Items.Add(i + "." + Path.GetFileName(file));
            }

            if(imgList.Items.Count > 0)
            {
                saveBtn.Enabled = true;
            }

            else
            {
                saveBtn.Enabled = false;
            }
        }

        private int ResizeAndSave()
        {
            progressBar.Maximum = imgList.Items.Count;

            int filesSaves = 0;

            if (overwriteCheck.Checked)
            {
                foreach (string file in FileHandler.ReadFiles())
                {
                    if(ImageHandler.Resize(file))
                    {
                        if(ImageHandler.Save(file))
                        {
                            filesSaves++;
                        }
                    }

                    progressBar.PerformStep();
                }
            }

            else
            {
                if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string newPath = folderBrowserDialog.SelectedPath;
                    string fileName;

                    foreach (string file in FileHandler.ReadFiles())
                    {
                        fileName = Path.GetFileName(file);

                        int count = 0;

                        while(File.Exists(Path.Combine(newPath, fileName)))
                        {
                            count++;

                            fileName = "(" + count + ")" + Path.GetFileName(file);
                        }

                        if(ImageHandler.Resize(file))
                        {
                            if(ImageHandler.Save(Path.Combine(newPath, fileName)))
                            {
                                filesSaves++;
                            }
                        }

                        progressBar.PerformStep();
                    }
                }
            }

            return filesSaves;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in this.openFileDialog.FileNames)
                {
                    if (ImageHandler.isJpeg(file) && FileHandler.NotDuplicate(file))
                    {
                        FileHandler.AddFile(file);
                    }
                }
            }
        }

        private void imgList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.imgList.SelectedIndex != -1)
            {
                try
                {
                    using (Image image = Image.FromFile(FileHandler.ReadFiles()[this.imgList.SelectedIndex]))
                    {
                        stream.Position = 0;

                        image.Save(stream, image.RawFormat);

                        image.Dispose();

                        if (previewPic.Image != null)
                        {
                            previewPic.Image.Dispose();
                        }

                        previewPic.Image = Image.FromStream(stream);

                        previewPic.Cursor = Cursors.Hand;
                    }
                }

                catch (FileNotFoundException)
                {
                    MessageBox.Show("Nie znaleziono pliku: " + FileHandler.ReadFiles()[this.imgList.SelectedIndex], "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    FileHandler.RemoveFile(this.imgList.SelectedIndex);
                }

                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Nieprawidłowy format pliku: " + FileHandler.ReadFiles()[this.imgList.SelectedIndex], "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    FileHandler.RemoveFile(this.imgList.SelectedIndex);
                }
            }
        }

        private void imgList_DeletePressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete && this.imgList.SelectedIndex != -1)
            {
                FileHandler.RemoveFile(this.imgList.SelectedIndex);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if(overwriteCheck.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno nadpisać?", "Nadpisz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dialogResult == DialogResult.No)
                {
                    ok = false;
                }
            }
            
            if(ok)
            {
                groupBoxPictures.Enabled = false;
                groupBoxSave.Enabled = false;

                btnAdvanced.Enabled = false;
                previewPic.Enabled = false;

                this.Cursor = Cursors.WaitCursor;

                int filesSaves = ResizeAndSave();

                if (filesSaves > 0)
                {
                    MessageBox.Show("Zmniejszono i zapisano pomyślnie " + filesSaves + " z " + imgList.Items.Count + " zdjęć", "Podsumowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Cursor = Cursors.Default;
                }

                else
                {
                    this.Cursor = Cursors.Default;
                }

                progressBar.Value = 0;

                groupBoxPictures.Enabled = true;
                groupBoxSave.Enabled = true;

                btnAdvanced.Enabled = true;
                previewPic.Enabled = true;
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            if(imgList.Items.Count > 0)
            {
                FileHandler.ClearFiles();
            }
        }
                
        private void previewPic_Click(object sender, EventArgs e)
        {
            if (previewPic.Image != null)
            {
                using (FormPicture formPicture = new FormPicture())
                {
                    formPicture.SetPicture(stream);

                    formPicture.ShowDialog();
                }
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            using (FormAdvanced formAdvanced = new FormAdvanced())
            {
                formAdvanced.ShowDialog();
            }
        }
    }
}
