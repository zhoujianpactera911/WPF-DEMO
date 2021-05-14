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
using System.Windows.Xps.Packaging;
using System.IO;
using System.Printing;


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
            XpsDocument doc = new XpsDocument(@"C:\demo.xps", FileAccess.Read);
            FixedDocumentSequence fds = doc.GetFixedDocumentSequence();
            documentViewer1.Document = fds;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.PageRangeSelection = PageRangeSelection.AllPages;
            pd.UserPageRangeEnabled = true;

            bool? ok = pd.ShowDialog();
            if (ok == true)
            {
                XpsDocument doc = new XpsDocument(@"C:\demo.xps", FileAccess.Read);
                FixedDocumentSequence fds = doc.GetFixedDocumentSequence();
                pd.PrintDocument(fds.DocumentPaginator, "Demo #1");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            LocalPrintServer lps = new LocalPrintServer();
            PrintQueue pq = lps.DefaultPrintQueue;

            pq.AddJob("Demo #1", @"C:\demo.xps", false);
        }
    }
}
