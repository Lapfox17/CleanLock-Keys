using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CleanLock_Keys
{
    static class InputBlock
    {
        [DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool BlockInput([MarshalAsAttribute(UnmanagedType.Bool)] bool fBlockIt);

        private static System.Timers.Timer iTimer;

        static InputBlock()
        {
            iTimer.Elapsed += new ElapsedEventHandler(iTimer_Tick);
        }

        public static void BlockInput(int milliseconds)
        {
            BlockInput(true);
            iTimer.Interval = milliseconds;
            iTimer.Start();

        }
        private static void iTimer_Tick(object sender, EventArgs e)
        {
            BlockInput(false);
            iTimer.Stop();
        }
    }
}
