using System.Windows;
using System.Windows.Media;

namespace WpfShapes.Models.Shapes
{
    public sealed class Circle : Ellipse
    {
        private readonly Brush DefaultFillColor = Brushes.Orange;

        public Circle(double radius) : base(new Point(radius, radius))
        {
            SetFillBrush(DefaultFillColor);
        }

        public Circle(double radius, Point offset) : base(new Point(radius, radius), offset)
        {
            SetFillBrush(DefaultFillColor);
        }
    }
}
