using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;

namespace KzBot2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum WM : int
        {
            WM_MOUSEMOVE = 0x200,
            WM_LBUTTONDOWN = 0x201,
            WM_LBUTTONUP = 0X202,
            WM_LBUTTONCLICK = 0X203
        }

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(int xPoirnt, int yPoint);
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(String sClassName, String sAppName);
        [DllImport("user32.dll")]
        static extern IntPtr FindWindowEx(IntPtr parentHandel, IntPtr childAfter, String sClassName, String windowTitle);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hwnd);
        private int MAKELPARAM(int x, int y)
        {
            return ((y << 16) | (x & 0xFFFF));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point pt = new Point(229, 352);
            Point pt2 = new Point(187, 300);

            IntPtr NoxhWnd = FindWindow("Qt5QWindowIcon", null); //specify Nox Emulator name if multiple instances

            //SetForegroundWindow(NoxhWnd);

            Thread.Sleep(2000);
            SendMessage(NoxhWnd, (int)WM.WM_LBUTTONDOWN, 1, MAKELPARAM(pt.X, pt.Y)); //SendMessage(handle, (int)WM.WM_LBUTTONUP, 1, MAKELPARAM(pt.X, pt.Y));
            SendMessage(NoxhWnd, (int)WM.WM_MOUSEMOVE, 0, MAKELPARAM(pt.X, pt.Y));

            Thread.Sleep(1000);
            SendMessage(NoxhWnd, (int)WM.WM_LBUTTONDOWN, 1, MAKELPARAM(pt2.X, pt2.Y));
            SendMessage(NoxhWnd, (int)WM.WM_MOUSEMOVE, 0, MAKELPARAM(pt2.X, pt2.Y));
        }
        


    }
}
