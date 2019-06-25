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

namespace Mod2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyNewMethod();

            student s = new student();
            s.Save();
        }

        private void MyNewMethod()
        {
            Int32 a = 5;
            Int32 b = 7;
            Int16 c;
            logger.Info("Clicking a button");
            ;
            c = (short)addNumbers(y: b, x: a);
            MessageBox.Show($"a:{a}  b:{b}  c:{c}");
        }

        Int32 addNumbers(Int32 x,  Int32 y)
        {
            Int32 result = x + y;
            y = 0;

            return result;
        }

        public student GetStudent(Int32 sid)
        {
            student s = new student();
            return s;
        }

    }

    public class student
    {
        public string FirstName = "";
        public string LastName = "";

        public bool Save()
        {
            return Save(@"c:\test.txt");
        }

        public bool Save(string filepath)
        {
            bool result = true;
            //allow user to specify where to save file
           
            System.IO.StreamWriter sw
                = new System.IO.StreamWriter(filepath);
            try
            {
                sw.WriteLine($"FirstName:{this.FirstName}");
                sw.WriteLine("LastName:" + this.LastName);
            }
        catch(Exception ex)
            {

            }
            finally
            {
                sw.Close();
                sw.Dispose();
            }
            

            return result;



        }
    }
}
