using System.Drawing;

namespace Paint.WorkColor
{
    class InvertColor
    {
        public delegate void ProgressDelegate(int procent);
        public static event ProgressDelegate ProgressEvent;

        /// <summary>
        /// Flow blocker. To sync
        /// </summary>
        private static readonly object key = new object();

        public static Bitmap Invert(Bitmap o)
        {
            Bitmap bitmap = (Bitmap)o.Clone(); 
            Color tmpColor;
            int p = 0;
            lock (key)
            {
                for (int i = 0; i < bitmap.Height; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        tmpColor = bitmap.GetPixel(j, i);
                        p = 100 * i / bitmap.Height;
                        try
                        {
                            unchecked
                            {
                                bitmap.SetPixel(j, i, Color.FromArgb(
                                    (byte)(tmpColor.R - 150),
                                    (byte)(tmpColor.G - 150),
                                    (byte)(tmpColor.B - 150)));
                            }
                        }
                        catch { }
                    }

                    if (p % 10 == 0 && bitmap.Height != i)
                    {
                        ProgressEvent(p);
                        System.Threading.Thread.Sleep(10);
                    }
                }
            }
            ProgressEvent(100);
            return bitmap;
        }
    }
}
