using System.Drawing;
using System.IO;

namespace CarRentalSystem.Utils
{
    internal class ImageHelper
    {
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        public static Image ResizeImage(Image img, int width, int height)
        {
            if (img == null) return null;

            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }
    }
}
