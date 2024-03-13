using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfShapes.Utils
{
    public static class Transform
    {
        public static void Translate(this Shape shape, Point translation)
        {
            shape.RenderTransform = new TranslateTransform(translation.X, translation.Y);
        }

        public static void Rotate(this Shape shape, double angle, Point center)
        {
            shape.RenderTransform = new RotateTransform(angle, center.X, center.Y);
        }

        public static void TranslateAndRotate(this Shape shape, Point translation, double angle, Point center)
        {
            TransformGroup group = new TransformGroup();
            group.Children.Add(new TranslateTransform(translation.X, translation.Y));
            group.Children.Add(new RotateTransform(angle, center.X, center.Y));
            shape.RenderTransform = group;
        }
    }
}
