using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.data
{
    public class Book
    {
        public Int32 BookId { get; set; }
        public string Title { get; set; }
        public Int32 PublishYear { get; set; }
    }
}
