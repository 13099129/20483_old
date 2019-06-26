using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4.Model
{
    public class BasicTransferManager : ITransferManager
    {
      
        public event SendStatus Status;

        private Int32 numberOfFilesSent=0;

        public bool Send(IPackage package, string destination)
        {
            Status("Starting");
            bool result =false;
            //todo: implementn this code
            foreach(var fileinfo in package.Files)
            {
                //todo:send file
                numberOfFilesSent++;
                Status($"Sent:{fileinfo.Name}");
            }
            Status("Done");
            return result;
        }
    }
}
