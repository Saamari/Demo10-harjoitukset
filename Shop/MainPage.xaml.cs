﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Shop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //change default window startup mode
            ApplicationView.PreferredLaunchWindowingMode
                = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            //window size
            ApplicationView.PreferredLaunchViewSize = new Size(800, 600);


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = " ";
            if ((bool) checkBeer.IsChecked)
            
            {
                textBox.Text +=  " " + checkBeer.Content.ToString();
            }
            if ((bool)checkCandy.IsChecked)

            {
                textBox.Text += " " + checkCandy.Content.ToString();
            }
            if ((bool)checkMilk.IsChecked)

            {
                textBox.Text += " " + checkMilk.Content.ToString();
            }

            if ((bool)checkMeat.IsChecked)

            {
                textBox.Text += " " + checkMeat.Content.ToString();
            }

            
        }
    }
}
