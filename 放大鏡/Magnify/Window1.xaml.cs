using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Input;


namespace Magnify
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            VisualBrush b = (VisualBrush) magnifierEllipse.Fill;
            b.Visual = mainUI;     // �]�w VisualBrush �����e�ӷ�

            checkEnableMagnifier.Checked += MagnifierEnabledChanged;
            checkEnableMagnifier.Unchecked += MagnifierEnabledChanged;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // �ҥΩΰ��Ω�j�� (��ܻP�_)
        private void MagnifierEnabledChanged(object sender, EventArgs e)
        {
            if (magnifierCanvas != null && checkEnableMagnifier != null)
            {
                magnifierCanvas.Visibility = 
                    (checkEnableMagnifier.IsChecked ?? false) ?
                        Visibility.Visible : Visibility.Hidden;
            }
        }

        // txtTargetSize �ܧ�ɡA�n���ܩ�j�誺 VisualBrush �d��
        private void ZoomChanged(object sender, EventArgs e)
        {
            if (magnifierEllipse != null)
            {
                VisualBrush b = (VisualBrush) magnifierEllipse.Fill;
                Rect viewBox = b.Viewbox;
                double val;
                if (!double.TryParse(txtTargetSize.Text, out val)) return;
                viewBox.Width = val;
                viewBox.Height = val;
                b.Viewbox = viewBox;

            }
        }

        // �ƹ����ʩ�j��
        private void OnMoveOverMainUI(object sender, MouseEventArgs e)
        {
            VisualBrush b = (VisualBrush) magnifierEllipse.Fill;
            Point pos = e.MouseDevice.GetPosition(mainUI);
            Rect viewBox = b.Viewbox;
            double xoffset = viewBox.Width / 2.0;
            double yoffset = viewBox.Height / 2.0;
            viewBox.X = pos.X - xoffset;
            viewBox.Y = pos.Y - yoffset;
            b.Viewbox = viewBox;
            Canvas.SetLeft(magnifierCanvas, pos.X - magnifierEllipse.Width / 2);
            Canvas.SetTop(magnifierCanvas, pos.Y - magnifierEllipse.Height / 2);
        }

    }
}