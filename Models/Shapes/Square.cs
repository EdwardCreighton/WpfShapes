using System.Windows;
using System.Windows.Media;

namespace WpfShapes.Models.Shapes
{
    public sealed class Square : Rectangle
    {
        private readonly Brush DefaultFillBrush = Brushes.DarkGreen;

        public Square(double sizeExtent) : base(new Point(sizeExtent, sizeExtent))
        {
            SetFillBrush(DefaultFillBrush);
        }

        public Square(double sizeExtent, Point offset) : base(new Point(sizeExtent, sizeExtent), offset)
        {
            SetFillBrush(DefaultFillBrush);
        }

        public Square(double sizeExtent, Point offset, double angle) : base(new Point(sizeExtent, sizeExtent), offset, angle)
        {
            SetFillBrush(DefaultFillBrush);
        }
    }
}
