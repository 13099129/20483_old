using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkDemo.data
{
    public class LibraryContext:DbContext
    {
        static string db = "server=student\\sqlexpress;database=library;integrated security=true";
        public LibraryContext():base(db)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
