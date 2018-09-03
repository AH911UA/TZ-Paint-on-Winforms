using System.Drawing;

namespace Paint
{
    
    abstract class Shape
    {
        public static Point PointStart { get; set; }
        public static bool IsFill { get; set; } = false;

        protected Graphics graphics;
        protected SolidBrush solidBrush;

        public Shape() {}
    }
}
