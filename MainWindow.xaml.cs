using System.Windows;
using WpfShapes.ViewModels;

namespace WpfShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void DrawShape(IShape s)
        {
            MainCanvas.Children.Add(s.ShapeInternal);
        }
    }
}