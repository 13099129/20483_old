using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4.Model
{
    public interface IPackage
    {
        string Name { get; set; }
        Guid TrackingNumber { get; set; }
        List<System.IO.FileInfo> Files { get; set; }
    }
}
