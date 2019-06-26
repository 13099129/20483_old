using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.data
{
    public class Author
    {
        public Int64 AuthorID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate;

        private string _birthPlace;
        public string BirthPlace
        {
            get { return _birthPlace; }
            set { _birthPlace = value; }
        }

        public string Serialize()
        {
            string result;
            result = "ID: " + this.AuthorID + ", Name:" + this.Name;
            return result;
        }

    }
}
