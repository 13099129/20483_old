using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo
{
    public class Book
    {
        public Int32 BookID { get; set; }
        public string Title { get; set; }
    }

    public class LibraryContext:System.Data.Entity.DbContext
    {
        public LibraryContext() : base("server=student\\sqlexpress;database=library2;integrated security=true")
        {

        }

        public System.Data.Entity.DbSet<Book> Books { get; set; } 
    }

}
