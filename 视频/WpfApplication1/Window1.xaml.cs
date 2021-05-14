﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            timeSlider.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        private void MediaTimeline_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            timeSlider.Value = mediaElement1.Position.TotalMilliseconds;
        }
    }
}
