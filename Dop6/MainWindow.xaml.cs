using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dop6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.Aqua, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.IndianRed, 1));
            this.Resources.Add("buttonG", gradientBrush);
            But1.Background = (Brush)this.Resources["buttonG"];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Resources["redStyle"] = new SolidColorBrush(Colors.BurlyWood);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            News News = new News();
            News.Show();
        }
    }
}
