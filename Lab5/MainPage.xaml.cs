using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Lab5
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        // NUMBER BUTTONS (Used for numbers)
        // Occupied Buttons: Numbers 0-9

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "1";
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "2";
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "3";
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "4";
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "5";
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "6";
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "7";
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "8";
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "9";
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "0";
        }

        // SPECIAL SIGN BUTTONS (Used for operations)
        // Occupied Buttons: C (Clear Button), + (Addition), - (Subtraction), * (Multiplication), / (Division)

        private void button_comma_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += ",";
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text = String.Empty;
        }

        private void button_operation_add_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "+";
        }

        private void button_operation_subtract_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "-";
        }

        private void button_operation_multiply_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "*";
        }

        private void button_operation_divide_Click(object sender, RoutedEventArgs e)
        {
            calc_output.Text += "/";
        }

        // CALCULATION (Used for output in text box)
        // Occupied Buttons: = (Button used to execute the calculation of textbox)

        // Source: "Simple Calculator Using WPF In C#" - Vinay Singh
        // https://www.c-sharpcorner.com/Blogs/simple-calculator-using-wpf-in-c-sharp

        private void button_calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                calc_output.Text = "Error!";
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (calc_output.Text.Contains("+"))
            {
                iOp = calc_output.Text.IndexOf("+");
            }
            else if (calc_output.Text.Contains("-"))
            {
                iOp = calc_output.Text.IndexOf("-");
            }
            else if (calc_output.Text.Contains("*"))
            {
                iOp = calc_output.Text.IndexOf("*");
            }
            else if (calc_output.Text.Contains("/"))
            {
                iOp = calc_output.Text.IndexOf("/");
            }
            else
            {

            }

            op = calc_output.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(calc_output.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(calc_output.Text.Substring(iOp + 1, calc_output.Text.Length - iOp - 1));

            if (op == "+")
            {
                calc_output.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                calc_output.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                calc_output.Text += "=" + (op1 * op2);
            }
            else
            {
                calc_output.Text += "=" + (op1 / op2);
            }

        }
        // End of outsourced code
    }
}