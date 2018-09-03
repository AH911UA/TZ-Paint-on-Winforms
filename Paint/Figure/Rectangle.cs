using System.Drawing;

namespace Paint.Figure
{
    class Rectangle : Shape
    {
        public Rectangle(ref Bitmap bitmap, ref Pen pen, ref Point pointEnd)
        {
            graphics = Graphics.FromImage(bitmap);
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle();

            if (PointStart.X < pointEnd.X && PointStart.Y < pointEnd.Y)
                rectangle = new System.Drawing.Rectangle(
                    PointStart.X,
                    PointStart.Y,
                    pointEnd.X - PointStart.X,
                    pointEnd.Y - PointStart.Y);

            else if (PointStart.X > pointEnd.X && PointStart.Y > pointEnd.Y)
                rectangle = new System.Drawing.Rectangle(
                    pointEnd.X,
                    pointEnd.Y,
                    PointStart.X - pointEnd.X,
                    PointStart.Y - pointEnd.Y);

            else if (PointStart.Y > pointEnd.Y && PointStart.X < pointEnd.X)
                rectangle = new System.Drawing.Rectangle(
                    PointStart.X,
                    pointEnd.Y,
                    pointEnd.X - PointStart.X,
                    PointStart.Y - pointEnd.Y);

            else if (PointStart.Y < pointEnd.Y)
                rectangle = new System.Drawing.Rectangle(
                    pointEnd.X, PointStart.Y,
                    PointStart.X - pointEnd.X,
                    pointEnd.Y - PointStart.Y);
 
            else if (PointStart.Y > pointEnd.Y)
                rectangle = new System.Drawing.Rectangle(
                    pointEnd.X,
                    pointEnd.Y,
                    PointStart.X - pointEnd.X,
                    PointStart.Y - pointEnd.Y);

            if (IsFill)
                DrawFillFig(ref pen, ref rectangle);
            else DrawFig(ref pen, ref rectangle);

        }

        private void DrawFillFig(ref Pen pen, ref System.Drawing.Rectangle rec)
        {
            solidBrush = new SolidBrush(pen.Color);
            graphics.FillRectangle(solidBrush, rec);
        }
        private void DrawFig(ref Pen pen, ref System.Drawing.Rectangle rec)
        {
            graphics.DrawRectangle(pen, rec);
        }
    }
}
