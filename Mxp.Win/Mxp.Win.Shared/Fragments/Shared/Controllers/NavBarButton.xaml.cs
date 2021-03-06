﻿using System;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Mxp.Win
{
    public sealed partial class NavBarButton : UserControl
    {
   
            public NavBarButton()
            {
                this.InitializeComponent();
                SetVisual();
            }
            public void SetVisual(String name = "", String path = "")
            {
                this.TextBlockName.Text = name;
                Uri uri = new Uri("ms-appx:" + path, UriKind.Absolute);

                BitmapImage imgSource = new BitmapImage(uri);
                this.ImageIcon.Source = imgSource;
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {

            }
        }
    }

