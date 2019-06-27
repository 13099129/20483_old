using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo.models
{
    class TaskExecutor:System.Collections.Generic.Queue<basicTask>
    {
        public void RunOnce()
        {
            var t = this.Dequeue();
            t.Run();
        }

        public void dowork(basicTask task)
        {
            task.Run();
        }

    }


    class basicTask
    {
        public virtual  void Run()
        {
//basic run
        }
    }

    class BackUpTask:basicTask
    {
        public override void Run()
        {
//do bakvc up stuff
        }
    }

    class FTPTask:basicTask
    {
        public override void Run()
        {
//ftp stuff
        }
    }
}
