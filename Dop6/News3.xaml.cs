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
using System.Windows.Shapes;

namespace Dop6
{
    /// <summary>
    /// Логика взаимодействия для News3.xaml
    /// </summary>
    public partial class News3 : Window
    {
        public News3()
        {
            InitializeComponent();

            List<string> styles = new List<string> { "Slovar/light", "Slovar/Dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "Dark";
        }
        private void ThemeChange(object sender, SelectionChangedEventArgs e) 
        {
            string style = styleBox.SelectedItem as string;  
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            ResourceDictionary resDict = Application.LoadComponent(uri)as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resDict);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SamostoatelnaaRebota SamostoatelnaaRebota = new SamostoatelnaaRebota();
            SamostoatelnaaRebota.Show();
        }
    }
}
