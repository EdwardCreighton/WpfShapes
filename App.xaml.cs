using System.Windows;
using WpfShapes.Models.Shapes;

namespace WpfShapes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            MainWindow window = new MainWindow();
            MainWindow = window;

            window.DrawShape(new Ellipse(new Point(80.0, 40.0), new Point(200.0, 200.0), 30.0));
            window.DrawShape(new Circle(40, new Point(100.0, 200.0)));
            window.DrawShape(new Square(50.0, new Point(250.0, 70.0), 45.0));
            window.DrawShape(new EquilateralTriangle(100.0, new Point(100.0, 100.0), 180.0));
            window.DrawShape(new RightTriangle(new Point(100.0, 70.0), new Point(400.0, 300.0), 270.0));

            MainWindow.Show();
        }
    }
}
