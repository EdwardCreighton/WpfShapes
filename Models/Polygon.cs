using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using WpfShapes.ViewModels;

namespace WpfShapes.Models
{
    public class Polygon : IShape
    {
        private readonly Brush DefaultFillBrush = Brushes.DarkRed;
        private readonly Brush DefaultStrokeBrush = Brushes.DarkGray;

        private readonly System.Windows.Shapes.Polygon _polygon;

        public Shape ShapeInternal => _polygon;

        public Polygon(IEnumerable<Point> points)
        {
            _polygon = new System.Windows.Shapes.Polygon();
            _polygon.Points = new PointCollection(points);

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);
        }

        public Polygon(IEnumerable<Point> points, double leftOffset, double topOffset)
        {
            _polygon = new System.Windows.Shapes.Polygon();
            _polygon.Points = new PointCollection(points);

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            TranslateTransform transform = new TranslateTransform(leftOffset, topOffset);
            _polygon.RenderTransform = transform;
        }

        public Polygon(IEnumerable<Point> points, double leftOffset, double topOffset, double angle)
        {
            _polygon = new System.Windows.Shapes.Polygon();
            _polygon.Points = new PointCollection(points);

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            Point center = new Point();

            foreach(var point in points)
            {
                center.X += point.X;
                center.Y += point.Y;
            }

            center.X /= points.Count();
            center.Y /= points.Count();

            TranslateTransform translate = new TranslateTransform(leftOffset, topOffset);
            RotateTransform rotate = new RotateTransform(angle, leftOffset + center.X, topOffset + center.Y);
            TransformGroup transformGroup = new TransformGroup();
            transformGroup.Children.Add(translate);
            transformGroup.Children.Add(rotate);
            _polygon.RenderTransform = transformGroup;
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
