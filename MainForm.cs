using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CleanLock_Keys
{
    public partial class MainForm : Form
    {

        [DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Keys vKeys);

        public MainForm()
        {
            InitializeComponent();
        }

        private void keyLockerButton_Click(object sender, EventArgs e)
        {
            BlockInput(true);
        }

        private static void getHotkeyPressed(object sender, KeyEventArgs e)
        {
            var ctrl = GetAsyncKeyState(Keys.ControlKey) & 0x8000;
            var key = GetAsyncKeyState(Keys.F10) & 0x8000;

            if(ctrl != 0 && key != 0)
            {
                BlockInput(false);
            }
        }
    }
}
