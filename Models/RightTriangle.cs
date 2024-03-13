using System.Windows;
using System.Windows.Media;

namespace WpfShapes.Models
{
    public sealed class RightTriangle : Triangle
    {
        private readonly Brush DefaultFillBrush = Brushes.Cyan;

        public RightTriangle(Point sizeExtent) : base(new Point(0.0, 0.0), new Point(sizeExtent.X, 0.0), new Point(0.0, sizeExtent.Y))
        {
            SetFillBrush(DefaultFillBrush);
        }

        public RightTriangle(Point sizeExtent, Point offset) : base(new Point(0.0, 0.0), new Point(sizeExtent.X, 0.0), new Point(0.0, sizeExtent.Y), offset)
        {
            SetFillBrush(DefaultFillBrush);
        }

        public RightTriangle(Point sizeExtent, Point offset, double angle) : base(new Point(0.0, 0.0), new Point(sizeExtent.X, 0.0), new Point(0.0, sizeExtent.Y), offset, angle)
        {
            SetFillBrush(DefaultFillBrush);
        }
    }
}
