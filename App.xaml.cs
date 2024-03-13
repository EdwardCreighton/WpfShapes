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

            window.DrawShape(new Models.Ellipse(100.0, 50.0, 100.0, 100.0));
            //window.DrawShape(new Models.Circle(50));
            window.DrawShape(new Models.Square(50.0, 50.0, 50.0));
            window.DrawShape(new Models.Square(50.0, 50.0, 50.0, 45.0));

            MainWindow = window;
            MainWindow.Show();
        }
    }
}
