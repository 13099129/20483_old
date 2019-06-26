using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.data
{
    public class Book
    {
        public Book()
        {
            BookId = 0;
            Title = "NA";
            PublishYear = DateTime.Today.Year;
        }
        public Book(string title)
        {
            BookId = 0;
            Title = title;
            PublishYear = DateTime.Today.Year;
        }


        public Int32 BookId { get; set; }
        public string Title { get; set; }
        public Int32 PublishYear { get; set; }
        public BookFormat Format { get; set; }
    }

    public enum BookFormat
    {
        Digital,
        Paper,
        Oral
    }
}
