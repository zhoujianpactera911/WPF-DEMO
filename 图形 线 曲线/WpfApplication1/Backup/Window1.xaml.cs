using System;
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ellipse1.Height = 300;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Line l1 = new Line();
            l1.X1 = 10;
            l1.Y1 = 10;
            l1.X2 = 200;
            l1.Y2 = 200;
            l1.Stroke = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            l1.StrokeThickness = 5;

            grid1.Children.Add(l1);
        }
    }
}
