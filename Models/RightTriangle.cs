using System.Windows;
using System.Windows.Media;

namespace WpfShapes.Models
{
    public sealed class RightTriangle : Triangle
    {
        private readonly Brush DefaultFillBrush = Brushes.Cyan;

        public RightTriangle(double widthExtent, double heightExtent) : base(new Point(0.0, 0.0), new Point(widthExtent, 0.0), new Point(0.0, heightExtent))
        {
            SetFillBrush(DefaultFillBrush);
        }

        public RightTriangle(double widthExtent, double heightExtent, double leftOffset, double topOffset) : base(new Point(0.0, 0.0), new Point(widthExtent, 0.0), new Point(0.0, heightExtent), leftOffset, topOffset)
        {
            SetFillBrush(DefaultFillBrush);
        }

        public RightTriangle(double widthExtent, double heightExtent, double leftOffset, double topOffset, double angle) : base(new Point(0.0, 0.0), new Point(widthExtent, 0.0), new Point(0.0, heightExtent), leftOffset, topOffset, angle)
        {
            SetFillBrush(DefaultFillBrush);
        }
    }
}
