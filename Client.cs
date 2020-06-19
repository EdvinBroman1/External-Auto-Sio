using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSio860
{
    class Client
    {
        public string ProcessStatus;
        public static Process Tibia;
        public static IntPtr BaseAddress;
        public bool isAttached;
        public Client()
        {
            AttachClient();
        }



        bool AttachClient()
        {
            List<Process> procs = Process.GetProcessesByName("Tibia").ToList();
            if(procs.Count == 0)
            {
                this.ProcessStatus = "Couldn't find Tibia.exe";
                this.isAttached = false;
                return false;
            }
            else
            {
                this.ProcessStatus = "Currently Attached To Tibia";
                Tibia = procs.FirstOrDefault();
                BaseAddress = Tibia.MainModule.BaseAddress;
                this.isAttached = true;
            }

            return false;
        }
    }
}
