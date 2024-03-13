using System.Windows;
using System.Windows.Media;

namespace WpfShapes.Models
{
    public sealed class EquilateralTriangle : Triangle
    {
        private readonly Brush DefaultFillBrush = Brushes.DeepPink;

        public EquilateralTriangle(double extentSize) : base(new Point(0.0, 0.0), new Point(0.5 * extentSize, Math.Sqrt(3) / 2.0 * extentSize), new Point(extentSize, 0.0))
        {
            SetFillBrush(DefaultFillBrush);
        }
        
        public EquilateralTriangle(double extentSize, double leftOffset, double topOffset) : base(new Point(0.0, 0.0), new Point(0.5 * extentSize, Math.Sqrt(3) / 2.0 * extentSize), new Point(extentSize, 0.0), leftOffset, topOffset)
        {
            SetFillBrush(DefaultFillBrush);
        }
        
        public EquilateralTriangle(double extentSize, double leftOffset, double topOffset, double angle) : base(new Point(0.0, 0.0), new Point(0.5 * extentSize, Math.Sqrt(3) / 2.0 * extentSize), new Point(extentSize, 0.0), leftOffset, topOffset, angle)
        {
            SetFillBrush(DefaultFillBrush);
        }
    }
}
