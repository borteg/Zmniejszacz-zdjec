using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zmniejszacz_zdjęć
{
    public partial class FormAdvanced : Form
    {
        private int tempWidth = ImageHandler.MaxWidth;
        private int tempHeight = ImageHandler.MaxHeight;
        private long tempQuality = ImageHandler.Quality;

        public FormAdvanced()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ImageHandler.MaxWidth = tempWidth;
            ImageHandler.MaxHeight = tempHeight;

            ImageHandler.Quality = tempQuality;

            this.Close();
        }

        private void changedQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempQuality = long.Parse((string)changedQuality.SelectedItem);

            CheckChanges();
        }

        private void FormAdvanced_Load(object sender, EventArgs e)
        {
            UserMaxWidth.Value = ImageHandler.MaxWidth;
            UserMaxHeight.Value = ImageHandler.MaxHeight;

            changedQuality.SelectedItem = ImageHandler.Quality.ToString();

            if(Install.IsAdmin())
            {
                if(Install.IsInstall())
                {
                    btnInstall.Text = "Odinstaluj";
                }

                else
                {
                    btnInstall.Text = "Instaluj";
                }

                btnInstall.Enabled = true;
                labelAdminInfo.Visible = false;
            }
        }

        private void UserMaxWidth_ValueChanged(object sender, EventArgs e)
        {
            tempWidth = (int)UserMaxWidth.Value;

            CheckChanges();
        }

        private void UserMaxHeight_ValueChanged(object sender, EventArgs e)
        {
            tempHeight = (int)UserMaxHeight.Value;

            CheckChanges();
        }

        private void CheckChanges()
        {
            if(tempWidth == ImageHandler.MaxWidth &&
               tempHeight == ImageHandler.MaxHeight &&
               tempQuality == ImageHandler.Quality)
            {
                btnApply.Enabled = false;
            }

            else
            {
                btnApply.Enabled = true;
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if(Install.IsInstall())
            {
                if(Install.Remove())
                {
                    MessageBox.Show("Odinstalowano pomyślnie", "Podsumowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnInstall.Text = "Instaluj";
                }

                else
                {
                    MessageBox.Show("Wystąpił błąd podczas deinstalacji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {
                if(Install.Installation())
                {
                    MessageBox.Show("Zainstalowano pomyślnie", "Podsumowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnInstall.Text = "Odinstaluj";
                }

                else
                {
                    MessageBox.Show("Wystąpił błąd podczas instalacji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
