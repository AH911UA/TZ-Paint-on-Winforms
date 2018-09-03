using System.Drawing;

namespace Paint.Figure
{
    class Line:Shape
    {
        public Line(ref Bitmap bitmap, ref Pen pen, ref Point pointEnd)
        {
            Graphics.FromImage(bitmap).DrawLine(
                pen, 
                PointStart.X, 
                PointStart.Y, 
                pointEnd.X, 
                pointEnd.Y);
        }
    }
}
