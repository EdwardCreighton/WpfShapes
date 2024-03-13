using System.Windows.Media;

namespace WpfShapes.Models
{
    public sealed class Square : Rectangle
    {
        private readonly Brush DefaultFillBrush = Brushes.DarkGreen;

        public Square(double sizeExtent) : base(sizeExtent, sizeExtent)
        {
            SetFillBrush(DefaultFillBrush);
        }

        public Square(double sizeExtent, double leftOffset, double topOffset) : base(sizeExtent, sizeExtent, leftOffset, topOffset)
        {
            SetFillBrush(DefaultFillBrush);
        }

        public Square(double sizeExtent, double leftOffset, double topOffset, double angle) : base(sizeExtent, sizeExtent, leftOffset, topOffset, angle)
        {
            SetFillBrush(DefaultFillBrush);
        }
    }
}
