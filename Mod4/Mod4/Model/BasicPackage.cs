using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4.Model
{
    public class BasicPackage : IPackage
    {
        public string Name {
            get ;
            set;
        }
        public Guid TrackingNumber {
            get;
            set ;
        }
        public List<FileInfo> Files
        {
            get;
            set;
        }
        = new List<FileInfo>();
    }
}
