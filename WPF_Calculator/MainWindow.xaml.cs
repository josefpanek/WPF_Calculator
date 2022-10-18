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

namespace WPF_Calculator
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

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            double inputOne = double.Parse(textBoxInputOne.Text);
            double inputTwo = double.Parse(textBoxInputTwo.Text);
            double result = 0;
            string operation = comboBoxOperation.Text;

            if (operation == "+")
                result = inputOne + inputTwo;
            else if (operation == "-")
                result = inputOne - inputTwo;
            else if (operation == "*")
                result = inputOne * inputTwo;
            else
            {
                if (inputTwo != 0)
                    result = inputOne / inputTwo;
                else
                    MessageBox.Show("Zero division not possible!");
            }

            textBlockResult.Text = result.ToString();
        }
    }
}
