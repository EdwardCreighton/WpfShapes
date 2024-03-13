using System.Windows;
using System.Windows.Media;

namespace WpfShapes.Models
{
    public class Rectangle : Polygon
    {
        private readonly Brush DefaultFillBrush = Brushes.LightGray;

        public Rectangle(Point sizeExtent)
            : base(new Point[]
                        {
                            new(0, 0),
                            new(sizeExtent.X * 2, 0),
                            new(sizeExtent.X * 2, sizeExtent.Y * 2),
                            new(0, sizeExtent.Y * 2),
                        })
        {
            SetFillBrush(DefaultFillBrush);
        }

        public Rectangle(Point sizeExtent, Point offset)
            : base(new Point[]
                        {
                            new(0, 0),
                            new(sizeExtent.X * 2, 0),
                            new(sizeExtent.X * 2, sizeExtent.Y * 2),
                            new(0, sizeExtent.Y * 2),
                        },
                  offset)
        {
            SetFillBrush(DefaultFillBrush);
        }

        public Rectangle(Point sizeExtent, Point offset, double angle)
            : base(new Point[]
                        {
                            new(0, 0),
                            new(sizeExtent.X * 2, 0),
                            new(sizeExtent.X * 2, sizeExtent.Y * 2),
                            new(0, sizeExtent.Y * 2),
                        },
                  offset,
                  angle)
        {
            SetFillBrush(DefaultFillBrush);
        }
    }
}
