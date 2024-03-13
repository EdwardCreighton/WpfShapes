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

        public Ellipse(double widthExtent, double heightExtent)
        {
            _ellipse = new System.Windows.Shapes.Ellipse();
            
            _ellipse.Width = widthExtent * 2.0;
            _ellipse.Height = heightExtent * 2.0;

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);
        }

        public Ellipse(double widthExtent, double heightExtent, double leftOffset, double topOffset)
        {
            _ellipse = new System.Windows.Shapes.Ellipse();

            _ellipse.Width = widthExtent * 2.0;
            _ellipse.Height = heightExtent * 2.0;

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            TranslateTransform transform = new TranslateTransform(leftOffset, topOffset);
            _ellipse.RenderTransform = transform;
        }

        public Ellipse(double widthExtent, double heightExtent, double leftOffset, double topOffset, double angle)
        {
            _ellipse = new System.Windows.Shapes.Ellipse();

            _ellipse.Width = widthExtent * 2.0;
            _ellipse.Height = heightExtent * 2.0;

            SetFillBrush(DefaultFillBrush);
            SetStrokeBrush(DefaultStrokeBrush);
            SetStrokeThickness(2.0);

            TranslateTransform translate = new TranslateTransform(leftOffset, topOffset);
            RotateTransform rotate = new RotateTransform(angle, leftOffset + widthExtent, topOffset + heightExtent);
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
