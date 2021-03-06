using System;
using System.Windows;
using System.Windows.Media;

namespace VideoText
{
    public partial class Window1 : Window
    {     
        public Window1()
        {
            InitializeComponent();   

            // 建立格式化文字物件
            FormattedText formattedText = new FormattedText(
                "曹祖聖",
                new System.Globalization.CultureInfo("zh-TW"),
                FlowDirection.LeftToRight,
                new Typeface(
                    new FontFamily("標楷體"),
                    FontStyles.Normal,
                    FontWeights.Bold,
                    FontStretches.Normal),
                120,
                Brushes.Red);

            // 建立文字外框的幾何物件
            Geometry geometry = new PathGeometry();
            geometry = formattedText.BuildGeometry(new Point(0, 0));

            // 調整幾何的比例，以便於可以和影片100% 重疊在一起
            ScaleTransform myScaleTransform = new ScaleTransform();
            myScaleTransform.ScaleX = .85;
            myScaleTransform.ScaleY = 1.85;
            geometry.Transform = myScaleTransform;

            // 建立路徑幾何
            PathGeometry pathGeometry = new PathGeometry();
            pathGeometry = geometry.GetFlattenedPathGeometry();

            //1. 套用到 XAML 中的 PATH 物件
            //path.Data = pathGeometry;

            // 2. 使用路徑幾何來裁剪影片
            //myMediaElement.Clip = pathGeometry;

            // 3. 讓白色小球依照字型外框移動
            //matrixAnimation.PathGeometry = pathGeometry;
            //ellipse.Visibility = Visibility.Visible;
        }
    }
}