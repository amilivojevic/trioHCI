﻿using HCI.GUI;
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

namespace HCI
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

        private void btnAddBusiness_Click(object sender, RoutedEventArgs e)
        {
            Window w = new PremisesDialog();
            w.ShowDialog();
        }

        private void btnAddType_Click(object sender, RoutedEventArgs e)
        {
            Window w = new TypeDialog();
            w.ShowDialog();
        }

        private void btnAddTag_Click(object sender, RoutedEventArgs e)
        {
            Window w = new TagsDialog();
            w.ShowDialog();
        }
    }
}
