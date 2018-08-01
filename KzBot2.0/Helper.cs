using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace KzBot2
{
    public static class Helper
    {
        public enum WM : int
        {
            WM_MOUSEMOVE = 0x200,
            WM_LBUTTONDOWN = 0x201,
            WM_LBUTTONUP = 0X202,
            WM_LBUTTONCLICK = 0X203
        }

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(int xPoirnt, int yPoint);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr parentHandel, IntPtr childAfter, String sClassName, String windowTitle);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hwnd);
        public static int MAKELPARAM(int x, int y)
        {
            return ((y << 16) | (x & 0xFFFF));
        }
    }
}
