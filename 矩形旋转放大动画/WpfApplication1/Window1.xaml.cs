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
using System.Windows.Forms;

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

        Timer t = new Timer();

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            t.Interval = 100;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        double angle = 0;
        double scale = 1;
        void t_Tick(object sender, EventArgs e)
        {
            TransformGroup tg = new TransformGroup();

            ScaleTransform st = new ScaleTransform(scale, scale);
            scale += 0.05;

            RotateTransform rt = new RotateTransform(angle);
            angle += 5;

            tg.Children.Add(st);
            tg.Children.Add(rt);

            rectangle1.RenderTransform = tg;
        }
    }
}
