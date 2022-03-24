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

namespace Project3
{
    
    public partial class MainWindow : Window
    {
        bool isOn = false;
        int sum = 0;
        bool operatorPressed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ONButton_Click(object sender, RoutedEventArgs e)
        {

            if (isOn) return;

            CalcInputBox1.Text = "0";
                isOn = true;

        }

        private void OFFButton_Click(object sender, RoutedEventArgs e)
        {

            CalcInputBox1.Text = "OFF";
            isOn = false;
            CalcExpressionBox1.Text = "";
            operatorPressed = false;
            sum = 0;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;

            CalcInputBox1.Text = "0";
            
        }

        private void ClearAllButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;
            CalcInputBox1.Text = "0";
            CalcExpressionBox1.Text = "";
            sum = 0;
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {

            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "1";

        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "2";

        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "3";

        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;

            int index = CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '-', '*' });

            if (operatorPressed && index != -1)
            {
                if (CalcExpressionBox1.Text.Contains(" - "))
                {
                    CalcExpressionBox1.Text = CalcExpressionBox1.Text.Replace(" - ", " / ");
                    return;
                }
                else if (CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '*' }) != -1)
                {
                    CalcExpressionBox1.Text = CalcExpressionBox1.Text.Replace(CalcExpressionBox1.Text[CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '*' })], '/');
                }
                return;
            }
            operatorPressed = true;
            if (CalcExpressionBox1.Text.Contains("="))
            {

                CalcExpressionBox1.Text = $"{CalcInputBox1.Text} / ";
                sum = int.Parse(CalcInputBox1.Text);
                return;
            }

            if (index != -1)
            {
                if ((CalcExpressionBox1.Text).Contains("+"))
                {
                    sum += int.Parse(CalcInputBox1.Text);

                }
                else if ((CalcExpressionBox1.Text).Contains(" - "))
                {
                    sum -= int.Parse(CalcInputBox1.Text);
                }
                else if ((CalcExpressionBox1.Text).Contains("*"))
                {
                    sum *= int.Parse(CalcInputBox1.Text);
                }
                else
                {
                    int i = int.Parse(CalcInputBox1.Text);

                    if (i == 0)
                    {
                        CalcExpressionBox1.Text = "Can't divide by 0";
                        CalcInputBox1.Text = "0";
                        sum = 0;
                    }
                    else
                    {
                        sum /= i;
                    }

                }

                CalcExpressionBox1.Text = sum + " / ";
                return;
            }

            CalcExpressionBox1.Text += CalcInputBox1.Text + " / ";

            sum += int.Parse(CalcInputBox1.Text);
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "4";

        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "5";

        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "6";

        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
          
            int index = CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '-', '*' });

            if (operatorPressed && index != -1)
            {
                
                if (CalcExpressionBox1.Text.Contains(" - "))
                {
                    CalcExpressionBox1.Text = CalcExpressionBox1.Text.Replace(" - ", " * ");
                    return;
                }
                else if (CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '*' }) != -1)
                {
                    CalcExpressionBox1.Text = CalcExpressionBox1.Text.Replace(CalcExpressionBox1.Text[CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '*' })], '*');
              
                }
                return;
            }
            operatorPressed = true;

            if (CalcExpressionBox1.Text.Contains("="))
            {

                CalcExpressionBox1.Text = $"{CalcInputBox1.Text} * ";
                sum = int.Parse(CalcInputBox1.Text);
                return;
            }

            if (index != -1)
            {
                if ((CalcExpressionBox1.Text).Contains("+"))
                {
                    sum += int.Parse(CalcInputBox1.Text);

                }
                else if ((CalcExpressionBox1.Text).Contains(" - "))
                {
                    sum -= int.Parse(CalcInputBox1.Text);
                }
                else if ((CalcExpressionBox1.Text).Contains("*"))
                {
                    sum *= int.Parse(CalcInputBox1.Text);
                }
                else
                {
                    sum /= int.Parse(CalcInputBox1.Text);

                }

                CalcExpressionBox1.Text = sum + " * ";
                return;
            }

            CalcExpressionBox1.Text += CalcInputBox1.Text + " * ";
            sum += int.Parse(CalcInputBox1.Text);
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "7";

        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "8";
          
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "9";
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e) 
        {
            if (!isOn) return;
            

            int index = CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '-', '*' });

            if (operatorPressed && index != -1)
            {

                if (CalcExpressionBox1.Text.Contains(" - ")) return;
                
                else if (CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '*' }) != -1)
                {
                    CalcExpressionBox1.Text = CalcExpressionBox1.Text.Replace(" " + CalcExpressionBox1.Text[CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '*' })] + " ", " - ");
                }
                return;
            }

            operatorPressed = true;
            
            
            if (CalcExpressionBox1.Text.Contains("="))
            {
                
                CalcExpressionBox1.Text = $"{CalcInputBox1.Text} - "; 
                sum = int.Parse(CalcInputBox1.Text);
                return;
            }
            

            
  
            if (index != -1)
            {
                if ((CalcExpressionBox1.Text).Contains("+"))
                {
                    sum += int.Parse(CalcInputBox1.Text);

                }
                else if ((CalcExpressionBox1.Text).Contains("/"))
                {
                    sum /= int.Parse(CalcInputBox1.Text);
                }
                else if ((CalcExpressionBox1.Text).Contains("*"))
                {
                    sum *= int.Parse(CalcInputBox1.Text);
                }
                else
                {
                    sum -= int.Parse(CalcInputBox1.Text);

                }

                CalcExpressionBox1.Text = sum + " - ";
                return;
            }
            CalcExpressionBox1.Text += (CalcInputBox1.Text + " - ");
            sum += int.Parse(CalcInputBox1.Text);

        }

        private void PlusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn || CalcInputBox1.Text.Equals("0")) return;

            if (CalcInputBox1.Text.Contains("-"))
            {
                CalcInputBox1.Text = CalcInputBox1.Text.Substring(1);
            }
            else
            {
                CalcInputBox1.Text = "-" + CalcInputBox1.Text;
            }
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (CalcExpressionBox1.Text.Contains("="))
            {
                CalcExpressionBox1.Text = "";
                sum = 0;

            }
            CalcInputBox1.Text = "0";
 
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;
            operatorPressed = false;

            if (!CalcExpressionBox1.Text.Contains("+") && !CalcExpressionBox1.Text.Contains("-") && !CalcExpressionBox1.Text.Contains("*") && !CalcExpressionBox1.Text.Contains("/") && CalcExpressionBox1.Text.Contains("="))
            {
                return;
            }

            CalcExpressionBox1.Text += CalcInputBox1.Text;


            if ((CalcExpressionBox1.Text).Contains("="))
            {
                int index = CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '-', '*' });
                int temp = int.Parse(CalcExpressionBox1.Text.Substring(index + 2, CalcExpressionBox1.Text.IndexOf("=") - index - 2 ));
                CalcExpressionBox1.Text = CalcInputBox1.Text + " " + CalcExpressionBox1.Text.Substring(index, 1) + " " + temp + " = ";

                if ((CalcExpressionBox1.Text).Contains("+"))
                {
                    CalcInputBox1.Text = (int.Parse(CalcInputBox1.Text) + temp) + "";

                }
                else if ((CalcExpressionBox1.Text).Contains(" - "))
                {
                    CalcInputBox1.Text = (int.Parse(CalcInputBox1.Text) - temp) + "";
                }
                else if ((CalcExpressionBox1.Text).Contains("*"))
                {
                    CalcInputBox1.Text = (int.Parse(CalcInputBox1.Text) * temp) + "";
                }
                else if ((CalcExpressionBox1.Text).Contains("/"))
                {
                    CalcInputBox1.Text = (int.Parse(CalcInputBox1.Text) / temp) + "";

                }

                sum = int.Parse(CalcInputBox1.Text);
                return;
            }
            
            if ((CalcExpressionBox1.Text).Contains("+"))
            {
                CalcInputBox1.Text = (sum + int.Parse(CalcInputBox1.Text)) + "";

            }
            else if ((CalcExpressionBox1.Text).Contains(" - "))
            {
                CalcInputBox1.Text = (sum - int.Parse(CalcInputBox1.Text)) + "";
            }
            else if ((CalcExpressionBox1.Text).Contains("*"))
            {
                CalcInputBox1.Text = (sum * int.Parse(CalcInputBox1.Text)) + "";
            }
            else if ((CalcExpressionBox1.Text).Contains("/"))
            {
                CalcInputBox1.Text = (sum / int.Parse(CalcInputBox1.Text)) + "";

            }
        
            CalcExpressionBox1.Text += " = ";
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isOn) return;

            int index = CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '-', '*' });

            if (operatorPressed && index != -1)
            {

                if (CalcExpressionBox1.Text.Contains(" - "))
                {
                    CalcExpressionBox1.Text = CalcExpressionBox1.Text.Replace(" - ", " * ");
                    return;
                }
                else if (CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '*' }) != -1)
                {
                    CalcExpressionBox1.Text = CalcExpressionBox1.Text.Replace(CalcExpressionBox1.Text[CalcExpressionBox1.Text.IndexOfAny(new char[] { '+', '/', '*' })], '+');
                
                }
                return;
            }

            operatorPressed = true;

            if (CalcExpressionBox1.Text.Contains("="))
            {

                CalcExpressionBox1.Text = $"{CalcInputBox1.Text} + ";
                sum = int.Parse(CalcInputBox1.Text);
                return;
            }

            if (index != -1)
            {
                if ((CalcExpressionBox1.Text).Contains("+"))
                {
                    sum += int.Parse(CalcInputBox1.Text);

                }
                else if ((CalcExpressionBox1.Text).Contains(" - "))
                {
                    sum -= int.Parse(CalcInputBox1.Text);
                }
                else if ((CalcExpressionBox1.Text).Contains("*"))
                {
                    sum *= int.Parse(CalcInputBox1.Text);
                }
                else
                {
                    sum /= int.Parse(CalcInputBox1.Text);

                }

                CalcExpressionBox1.Text = sum + " + ";      
                return;
            }   
            
            CalcExpressionBox1.Text += CalcInputBox1.Text + " + ";

            sum += int.Parse(CalcInputBox1.Text);

        }
    }
}
