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

namespace EntityFrameworkDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // InsertData();
        }

        public void InsertData()
        {
            data.LibraryContext ctx = new data.LibraryContext();
            data.Book book = new data.Book();
            book.Title = "Origin of Species";

            ctx.Books.Add(book);

            ctx.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            data.LibraryContext ctx = new data.LibraryContext();
            data.Book book = new data.Book();
            book.Title = this.title.Text;
            book.PublishYear = Convert.ToInt32(this.pubyear.Text);
            ctx.Books.Add(book);

            ctx.SaveChanges();
        }
    }
}
