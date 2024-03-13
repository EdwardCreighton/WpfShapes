using System.Windows;

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

            window.DrawShape(new Models.Ellipse(new Point(80.0, 40.0), new Point(200.0, 200.0)));
            window.DrawShape(new Models.Circle(40, new Point(100.0, 200.0)));
            window.DrawShape(new Models.Square(50.0, 50.0, 50.0, 45.0));
            window.DrawShape(new Models.EquilateralTriangle(25.0, 300.0, 300.0, 180.0));
            window.DrawShape(new Models.RightTriangle(50, 25.0, 300.0, 0));

            MainWindow = window;
            MainWindow.Show();
        }
    }
}
