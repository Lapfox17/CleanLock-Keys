using System.Runtime.InteropServices;

namespace CleanLock_Keys
{
    static class InputBlock
    {
        [DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool BlockInput([MarshalAsAttribute(UnmanagedType.Bool)] bool fBlockIt);
    }
}
