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

namespace CollectionDemo
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

        System.Collections.Hashtable myList 
            = new System.Collections.Hashtable();

        private Int32 keynumber = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            keynumber++;
            myList.Add(keynumber, this.txt1.Text);
            this.txt1.Text = "";
            this.txt1.Focus();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string x = myList[myList.Count-1] as string;
            
            MessageBox.Show(x);
        }

        private System.Collections.Stack mystack
            = new System.Collections.Stack();
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mystack.Push(this.qbox.Text);
            this.qbox.Text = "";
            this.qbox.Focus();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string x = mystack.Pop() as string;
            MessageBox.Show(x);
        }


        System.Collections.Generic.List<DateTime> moments
            = new List<DateTime>();
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            moments.Add(DateTime.Now);

            DateTime x = moments[0];
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { BookId = 1, Title = "Origin", Author = "Darwin", Genre = "Science" });
            books.Add(new Book() { BookId  =2, Title = "Sarum", Author = "Rutherford", Genre = "History" });
            books.Add(new Book() { BookId = 3, Title = "Wrinkle In Time", Author = "ElBright", Genre = "SCIFI" });
            books.Add(new Book() { BookId = 4, Title = "Praxis", Author = "Weldon", Genre = "Fiction" });

            //sql style of LINQ
            var scifiQuery = from b in books
                             where b.Genre == "SCIFI"
                             orderby b.Title
                             select new {Title=b.Title,Author=b.Author };

            var scifiresults = scifiQuery.ToList();

            foreach(var item in scifiresults)
            {
                MessageBox.Show(item.Title);
            }

            //OBJECT-METHOD Style

            var sciBooks = books.Where(rowItem => rowItem.Genre == "Science")
                .OrderBy(book => book.Title)
                .ToList();


        }
    }
}
