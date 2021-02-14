using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zmniejszacz_zdjęć
{
    public partial class FormPicture : Form
    {
        public FormPicture()
        {
            InitializeComponent();
        }

        public void SetPicture(MemoryStream stream)
        {
            previewPicForm.Image = Image.FromStream(stream);
        }
    }
}
