using System.Windows;
using System.Windows.Media;
using WpfShapes.Utils;
using WpfShapes.ViewModels;

namespace WpfShapes.Models.Shapes
{
    public class Ellipse : IShape
    {
        private readonly Brush DefaultFillBrush = Brushes.DeepSkyBlue;
        private readonly Brush DefaultStrokeBrush = Brushes.DarkGray;

        private System.Windows.Shapes.Ellipse _ellipse;

        public System.Windows.Shapes.Shape ShapeInternal => _ellipse;

        public Ellipse(Point sizeExtent)
        {
            _ellipse = new System.Windows.Shapes.Ellipse();

            _ellipse.Width = sizeExtent.X * 2.0;
            _ellipse.Height = sizeExtent.Y * 2.0;

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);
        }

        public Ellipse(Point sizeExtent, Point offset)
        {
            _ellipse = new System.Windows.Shapes.Ellipse();

            _ellipse.Width = sizeExtent.X * 2.0;
            _ellipse.Height = sizeExtent.Y * 2.0;

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            _ellipse.Translate(offset);
        }

        public Ellipse(Point sizeExtent, Point offset, double angle)
        {
            _ellipse = new System.Windows.Shapes.Ellipse();

            _ellipse.Width = sizeExtent.X * 2.0;
            _ellipse.Height = sizeExtent.Y * 2.0;

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            _ellipse.TranslateAndRotate(offset, angle, new Point(offset.X + sizeExtent.X, offset.Y + sizeExtent.Y));
        }

        public void SetFillBrush(Brush fillBrush)
        {
            _ellipse.Fill = fillBrush;
        }

        public void SetStrokeBrush(Brush strokeBrush)
        {
            _ellipse.Stroke = strokeBrush;
        }

        public void SetStrokeThickness(double thickness)
        {
            _ellipse.StrokeThickness = thickness;
        }
    }
}
