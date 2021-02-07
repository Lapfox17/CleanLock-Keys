using System;
using System.Windows.Forms;
using WK.Libraries.HotkeyListenerNS;

namespace CleanLock_Keys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var hk = new HotkeyListener();
            Hotkey unlockHotKey = new Hotkey(Keys.Control | Keys.M);

            hk.Add(unlockHotKey);
            hk.HotkeyPressed += HKPressedEvent;
        }

        private void keyLockerButton_Click(object sender, EventArgs e)
        {
            InputBlock.BlockInput(true);
        }

        private void HKPressedEvent(object sender, HotkeyEventArgs e)
        {
            InputBlock.BlockInput(false);
            MessageBox.Show("this is a test message");
        }
    }
}
