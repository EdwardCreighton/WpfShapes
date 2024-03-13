using System.Windows.Media;

namespace WpfShapes.Models
{
    public sealed class Circle : Ellipse
    {
        private readonly Brush DefaultFillColor = Brushes.Orange;

        public Circle(double radius) : base(radius, radius) 
        {
            SetFillBrush(DefaultFillColor);
        }

        public Circle(double radius, double leftOffset, double topOffset) : base(radius, radius, leftOffset, topOffset)
        {
            SetFillBrush(DefaultFillColor);
        }

        public Circle(double radius, double leftOffset, double topOffset, double angle) : base(radius, radius, leftOffset, topOffset, angle)
        {
            SetFillBrush(DefaultFillColor);
        }
    }
}
