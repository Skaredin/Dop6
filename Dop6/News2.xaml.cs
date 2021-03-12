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
    /// Логика взаимодействия для News2.xaml
    /// </summary>
    public partial class News2 : Window
    {
        public News2()
        {
            InitializeComponent();
            Style butSt = new Style();
            butSt.Setters.Add(new Setter {Property=Control.FontFamilyProperty, Value=new FontFamily("Verdana")});
            butSt.Setters.Add(new Setter { Property = Control.MarginProperty, Value = new Thickness(16)});
            But1.Style = butSt;
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            News3 News3 = new News3();
            News3.Show();
        }
    }
}
