using Paint.FieldDrow;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint.WorkFiles
{
    class FileOperations
    {
        public static void NewFile(Form1 parent, out FieldForm fieldDraw)
        {
            fieldDraw = Field.GetField(parent);
            fieldDraw.MdiParent = parent;
            fieldDraw.Show();
        }

        public static void SaveFile(ref FieldForm fieldDraw)
        {
            if (fieldDraw == null) return;

            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = $"{fieldDraw.Text}.png",
                Filter = "Image*.png|Image*.jpg"
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            fieldDraw.BitmapProp.Save(sfd.FileName);
        }

        public static FieldForm OpenFile(Form1 parent)
        {
            FieldForm fieldDraw = null;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "jpg|*.jpg| bmp|*.bmp"
                };

                if (ofd.ShowDialog() != DialogResult.OK) return null;

                Bitmap load = new Bitmap(ofd.FileName);
                load = GetResizedImage(load);
                fieldDraw = Field.GetField(parent, load);

                fieldDraw.Text = System.IO.Path.GetFileName(ofd.FileName);
                fieldDraw.MdiParent = parent;

                fieldDraw.Show();
            }
            finally { }

            return fieldDraw;
        }
        private static Bitmap GetResizedImage(Bitmap img)
        {
            Rectangle screenSize = Screen.PrimaryScreen.Bounds;

            int widht = img.Width;
            int height = img.Height;
            while (height > screenSize.Height)
            {
                height -= (int)(height * 0.05);
                widht -= (int)(widht * 0.05);
            }

            Bitmap bitmap = new Bitmap(widht, height);
            Graphics g = Graphics.FromImage(bitmap);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, 0, 0, widht, height);
            g.Dispose();

            try
            {
                return  (Bitmap)bitmap.Clone();
            }
            finally
            {
                bitmap.Dispose();
                bitmap = null;
                g = null;
            }
        }
    }
}
