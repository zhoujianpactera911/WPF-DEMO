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
            b.Visual = mainUI;     // 設定 VisualBrush 的內容來源

            checkEnableMagnifier.Checked += MagnifierEnabledChanged;
            checkEnableMagnifier.Unchecked += MagnifierEnabledChanged;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // 啟用或停用放大鏡 (顯示與否)
        private void MagnifierEnabledChanged(object sender, EventArgs e)
        {
            if (magnifierCanvas != null && checkEnableMagnifier != null)
            {
                magnifierCanvas.Visibility = 
                    (checkEnableMagnifier.IsChecked ?? false) ?
                        Visibility.Visible : Visibility.Hidden;
            }
        }

        // txtTargetSize 變更時，要改變放大鏡的 VisualBrush 範圍
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

        // 滑鼠移動放大鏡
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