using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Zmniejszacz_zdjęć
{
    class ImageHandler
    {

        private static int _maxWidth = 1024, _maxHeight = 1024;
        private static long _quality = 80;

        private static Bitmap newImage;

        public static int MaxWidth
        {
            get => _maxWidth;
            set => _maxWidth = value;
        }

        public static int MaxHeight
        {
            get => _maxHeight;
            set => _maxHeight = value;
        }

        public static long Quality
        {
            get => _quality;
            set => _quality = value;
        }

        public static bool Resize(string imagePath)
        {
            Bitmap origImage;

            try
            {
                origImage = new Bitmap(imagePath);

                if (!origImage.RawFormat.Equals(ImageFormat.Jpeg))
                {
                    MessageBox.Show("Nieprawidłowy format pliku: " + imagePath, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Nie można odczytać pliku: " + imagePath, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            int origWidth = origImage.Width;
            int origHeight = origImage.Height;

            float ratioX = (float)_maxWidth / (float)origWidth;
            float ratioY = (float)_maxHeight / (float)origHeight;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth, newHeight;

            if(ratio < 1)
            {
                newWidth = (int)(origWidth * ratio);
                newHeight = (int)(origHeight * ratio);
            }

            else
            {
                newWidth = origWidth;
                newHeight = origHeight;
            }

            newImage = new Bitmap(newWidth, newHeight, origImage.PixelFormat);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(origImage, 0, 0, newWidth, newHeight);
            }

            origImage.Dispose();

            return true;
        }

        public static bool Save(string path)
        {
            ImageCodecInfo imageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg);

            Encoder encoder = Encoder.Quality;

            EncoderParameters encoderParameters = new EncoderParameters(1);

            EncoderParameter encoderParameter = new EncoderParameter(encoder, _quality);

            encoderParameters.Param[0] = encoderParameter;

            try
            {
                newImage.Save(path, imageCodecInfo, encoderParameters);
            }

            catch(Exception)
            {
                if (!Install.IsAdmin())
                {
                    MessageBox.Show("Nie udało się zapisać pliku: " + path + "\nUpewnij się, że nie są wymagane uprawnienia administratora.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Nie udało się zapisać pliku: " + path, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return false;
            }

            if(newImage != null)
            {
                newImage.Dispose();
            }

            return true;
        }

        private static ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

        public static bool isJpeg(string file)
        {
            try
            {
                using(Image image = Image.FromFile(file))
                {
                    if(!image.RawFormat.Equals(ImageFormat.Jpeg))
                    {
                        MessageBox.Show("Nieprawidłowy format pliku: " + file, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Nie znaleziono pliku: " + file, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            catch(OutOfMemoryException)
            {
                MessageBox.Show("Nieprawidłowy format pliku: " + file, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
