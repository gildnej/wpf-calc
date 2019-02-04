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

namespace Wpf_SimpleCalculator
{
    /// <summary>
    /// Interaction logic for SolutionWindow.xaml
    /// </summary>
    public partial class SolutionWindow : Window
    {
        private TextBox answer;

        public SolutionWindow(int answer)
        {
            InitializeComponent();

            TextBox_answer.Text = answer.ToString();
            
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
