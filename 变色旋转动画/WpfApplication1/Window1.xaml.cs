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
using System.Windows.Media.Animation;

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
            DoubleAnimation da1 = new DoubleAnimation(
                1, 200, new Duration(new TimeSpan(0,0, 3)));
            da1.RepeatBehavior = RepeatBehavior.Forever;
            da1.AutoReverse = true;

            ColorAnimation ca1 = new ColorAnimation(
                Color.FromRgb(255, 0, 0), Color.FromRgb(0, 0, 255),
                new Duration(new TimeSpan(0, 0, 1)));
            ca1.RepeatBehavior = RepeatBehavior.Forever;
            ca1.AutoReverse = true;

            rectangle1.BeginAnimation(Rectangle.WidthProperty, da1);
            color1.BeginAnimation(SolidColorBrush.ColorProperty, ca1);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da1 = new DoubleAnimation(
                1, 200, new Duration(new TimeSpan(0, 0, 3)));
            da1.RepeatBehavior = RepeatBehavior.Forever;
            da1.AutoReverse = true;

            Storyboard sb = new Storyboard();
            Storyboard.SetTargetProperty(da1, new PropertyPath(Rectangle.WidthProperty));
            sb.Children.Add(da1);
            sb.Begin(rectangle1);

        }


    }
}
