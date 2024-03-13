using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfShapes.ViewModels
{
    public interface IShape
    {
        public Shape ShapeInternal { get; }
        public void SetFillBrush(Brush fillBrush);
        public void SetStrokeBrush(Brush strokeBrush);
        public void SetStrokeThickness(double thickness);
    }
}
