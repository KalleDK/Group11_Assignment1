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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Group11_Assignment1
{
    /// <summary>
    /// Interaction logic for DebitorsCreditorsView.xaml
    /// </summary>
    public partial class DebitorsCreditorsView : System.Windows.Window

    {
        public DebitorsCreditorsView()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddDepter addWindow = new AddDepter();
            addWindow.Show();
        }

        private void DeptersListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
