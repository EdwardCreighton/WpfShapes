using System.Windows;
using System.Windows.Media;

namespace WpfShapes.Models
{
    public class Triangle : Polygon
    {
        private readonly Brush DefaultFillBrush = Brushes.Coral;

        public Triangle(Point point1, Point point2, Point point3) : base(new Point[] { point1, point2, point3 })
        {
            SetFillBrush(DefaultFillBrush);
        }
        
        public Triangle(Point point1, Point point2, Point point3, double leftOffset, double topOffset) : base(new Point[] { point1, point2, point3 }, leftOffset, topOffset)
        {
            SetFillBrush(DefaultFillBrush);
        }
        
        public Triangle(Point point1, Point point2, Point point3, double leftOffset, double topOffset, double angle) : base(new Point[] { point1, point2, point3 }, leftOffset, topOffset, angle)
        {
            SetFillBrush(DefaultFillBrush);
        }
    }
}
