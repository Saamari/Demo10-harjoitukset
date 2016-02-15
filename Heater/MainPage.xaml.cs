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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Heater
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Property property = new Property();


        public MainPage()
        {

            this.InitializeComponent();

        }

        double value;
        bool check;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {

                for (int i = 0; i < 10; i++)
                {
                    if (button.Content.ToString() == i.ToString())
                    {
                        number.Text += button.Content.ToString();
                    }
                    if (button.Content.ToString() == "E")
                    {
                        if (number.Text != "")
                        {
                            string removeText = number.Text.Substring(0, number.Text.Length - 1);
                            number.Text = removeText;
                        }
                    }
                    if (button.Content.ToString() == ".")
                        number.Text += ".";
                }


            }

        }

        private void numberDot_Click(object sender, RoutedEventArgs e)
        {
            number.Text += numberDot.Content.ToString();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            if (heatButton.IsChecked == true)
            {
                if (check = (double.TryParse(number.Text, out value)))
                {
                    if (value <= 120)
                    {
                        TempBlock.Text = " " + value;
                    }
                    else if (value > 120)
                    {
                        TempBlock.Text = " Temp too high!";
                    }

                    if(humidityButton.IsChecked == true)
                    {
                        if (check = (double.TryParse(number.Text, out value)))
                        {
                            if (value <= 100)
                            {
                                HumiBlock.Text = " " + value;
                            }
                            else if (value > 100)
                            {
                                HumiBlock.Text = "ERROR";
                            }

                            TempBlock.Text = " ";
                        }
                    }
                }
            }
        }
    }
        }
    

