using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model.ITransferManager mgr = new Model.BasicTransferManager();
            mgr.Status += Mgr_Status; //explicit function Version
            //mgr.Status += (msg)=> { MessageBox.Show(msg); }; //anonymous function version
            Model.IPackage pck = new Model.BasicPackage();
            pck.Name = "Test1";
            pck.TrackingNumber = Guid.NewGuid();
            pck.Files.Add(new System.IO.FileInfo("c:\\test1.txt"));
            pck.Files.Add(new System.IO.FileInfo("c:\\test2.txt"));

            
            Model.FileCompressor.Smush("inpath", "outpath");


            mgr.Send(pck, "ftp://ftp.myserver.com");

        }

        private void Mgr_Status(string status)
        {
            //updaet interface
            //or log it down
            MessageBox.Show(status);
        }
    }
}
