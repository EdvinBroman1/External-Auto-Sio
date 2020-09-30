using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSio860
{
    class Healer
    {
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        const uint WM_KEYDOWN = 0x0100;
        static Memory mem = new Memory(Client.Tibia);
        public static void SendHeal(string PlayerName)
        {
            string spell = "Exura Sio \"" + PlayerName +"\0"; 
            mem.WriteStringPointer((UInt32)Client.BaseAddress + 0x24C25C, spell, new UInt32[] { 0x34, 0x40, 0x2C });
            PostMessage(Client.Tibia.MainWindowHandle, WM_KEYDOWN, (int)Keys.Enter, 0);
        }
    }
}
