using System.Windows;
using System.Windows.Media;

namespace WpfShapes.Models
{
    public class Rectangle : Polygon
    {
        private readonly Brush DefaultFillBrush = Brushes.LightGray;

        public Rectangle(double widthExtent, double heightExtent)
            : base(new Point[]
                        {
                            new(0, 0),
                            new(widthExtent * 2, 0),
                            new(widthExtent * 2, heightExtent * 2),
                            new(0, heightExtent * 2),
                        })
        {
            SetFillBrush(DefaultFillBrush);
        }

        public Rectangle(double widthExtent, double heightExtent, double leftOffset, double topOffset)
            : base(new Point[]
                        {
                            new(0, 0),
                            new(widthExtent * 2, 0),
                            new(widthExtent * 2, heightExtent * 2),
                            new(0, heightExtent * 2),
                        },
                  leftOffset,
                  topOffset)
        {
            SetFillBrush(DefaultFillBrush);
        }

        public Rectangle(double widthExtent, double heightExtent, double leftOffset, double topOffset, double angle)
            : base(new Point[]
                        {
                            new(0, 0),
                            new(widthExtent * 2, 0),
                            new(widthExtent * 2, heightExtent * 2),
                            new(0, heightExtent * 2),
                        },
                  leftOffset,
                  topOffset,
                  angle)
        {
            SetFillBrush(DefaultFillBrush);
        }
    }
}
