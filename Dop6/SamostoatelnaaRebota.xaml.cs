﻿using System;
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
    /// Логика взаимодействия для SamostoatelnaaRebota.xaml
    /// </summary>
    public partial class SamostoatelnaaRebota : Window
    {
        public SamostoatelnaaRebota()
        {
            InitializeComponent();
            MainFrame.Navigate(new HotelPage1());
            Manager.MainFrame = MainFrame;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {                 
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}
