﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Find_the_number
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Play_btn_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GuessPage.xaml", UriKind.Relative));
            
        }

        private void TextBlock_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Leaderboard.xaml", UriKind.Relative));
        }
    }
}