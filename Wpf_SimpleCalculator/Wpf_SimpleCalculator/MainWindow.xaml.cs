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

namespace Wpf_SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //initializeWindow();
        }



 
        void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            TextBox_answer = (int.Parse(TextBox_Num1.Text) + int.Parse(TextBox_Num2.Text)).ToString();

            

            
        }

        bool ValidInputs(out string userFeedback)
        {
            bool validInputs = true;
            userFeedback = "";

            if (!double.TryParse(TextBox_Num1.Text, out double tempLength))
            {
                validInputs = false;
                userFeedback += "It appears that the value entered for Number one is not a valid number." + Environment.NewLine;
            }
            if (!double.TryParse(TextBox_Num2.Text, out double tempWidth))
            {
                validInputs = false;
                userFeedback += "It appears that the value entered for Number two is not a valid number." + Environment.NewLine;
            }
            

            return validInputs;
        }

        void Button_Help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();

            helpWindow.ShowDialog();
        }

        private void Btn_Addition_Click(object sender, RoutedEventArgs e)
        {
           
            int num1 = Convert.ToInt32(TextBox_Num1.Text);

            int num2 = Convert.ToInt32(TextBox_Num2.Text);

            

        }
    }   
}