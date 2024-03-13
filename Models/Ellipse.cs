using System.Windows;
using System.Windows.Media;
using WpfShapes.ViewModels;

namespace WpfShapes.Models
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

            TranslateTransform transform = new TranslateTransform(offset.X, offset.Y);
            _ellipse.RenderTransform = transform;
        }

        public Ellipse(Point sizeExtent, Point offset, double angle)
        {
            _ellipse = new System.Windows.Shapes.Ellipse();

            _ellipse.Width = sizeExtent.X * 2.0;
            _ellipse.Height = sizeExtent.Y * 2.0;

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            TranslateTransform translate = new TranslateTransform(offset.X, offset.Y);
            RotateTransform rotate = new RotateTransform(angle, offset.X + sizeExtent.X, offset.Y + sizeExtent.Y);
            TransformGroup transformGroup = new TransformGroup();
            transformGroup.Children.Add(translate);
            transformGroup.Children.Add(rotate);
            _ellipse.RenderTransform = transformGroup;
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
