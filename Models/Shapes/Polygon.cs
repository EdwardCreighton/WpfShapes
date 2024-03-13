using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using WpfShapes.Utils;
using WpfShapes.ViewModels;

namespace WpfShapes.Models.Shapes
{
    public class Polygon : IShape
    {
        private readonly Brush DefaultFillBrush = Brushes.DarkRed;
        private readonly Brush DefaultStrokeBrush = Brushes.DarkGray;

        private readonly System.Windows.Shapes.Polygon _polygon;

        public Shape ShapeInternal => _polygon;

        public Polygon(IEnumerable<Point> points)
        {
            // Missing "points.Count == 0" exception check

            _polygon = new System.Windows.Shapes.Polygon();
            _polygon.Points = new PointCollection(points);

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);
        }

        public Polygon(IEnumerable<Point> points, Point offset)
        {
            // Missing "points.Count == 0" exception check

            _polygon = new System.Windows.Shapes.Polygon();
            _polygon.Points = new PointCollection(points);

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            _polygon.Translate(offset);
        }

        public Polygon(IEnumerable<Point> points, Point offset, double angle)
        {
            // Missing "points.Count == 0" exception check

            _polygon = new System.Windows.Shapes.Polygon();
            _polygon.Points = new PointCollection(points);

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            Point center = new Point();

            foreach (var point in points)
            {
                center.X += point.X;
                center.Y += point.Y;
            }

            center.X /= points.Count();
            center.Y /= points.Count();

            _polygon.TranslateAndRotate(offset, angle, new Point(offset.X + center.X, offset.Y + center.Y));
        }

        public void SetFillBrush(Brush fillBrush)
        {
            _polygon.Fill = fillBrush;
        }

        public void SetStrokeBrush(Brush strokeBrush)
        {
            _polygon.Stroke = strokeBrush;
        }

        public void SetStrokeThickness(double thickness)
        {
            _polygon.StrokeThickness = thickness;
        }
    }
}
