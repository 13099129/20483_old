using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4.Model
{
    public delegate void SendStatus(string status);

   public interface ITransferManager
    {
        event SendStatus Status;

        bool Send(IPackage package, string destination);

    }
}
