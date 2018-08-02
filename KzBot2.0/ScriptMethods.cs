using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace KzBot2
{
    class ScriptMethods
    {
        Random randomize = new Random();
        public void ClickRange(int x1, int y1, int x2, int y2)
        {
            Point pt = new Point(randomize.Next(x1, x2), randomize.Next(y1, y2));

            IntPtr NoxhWnd = Helper.FindWindow("Qt5QWindowIcon", null);
            IntPtr Child1 = Helper.FindWindowEx(NoxhWnd, IntPtr.Zero, null, "ScreenBoardClassWindow");
            IntPtr Child2 = Helper.FindWindowEx(Child1, IntPtr.Zero, null, "QWidgetClassWindow");
            Thread.Sleep(3000);
            Helper.PostMessage(Child2, (int)WM.WM_LBUTTONDOWN, (int)WM.MK_LBUTTON, Helper.MAKELPARAM(pt.X, pt.Y)); //SendMessage(handle, (int)WM.WM_LBUTTONUP, 1, MAKELPARAM(pt.X, pt.Y));
            Thread.Sleep(3000);
            int x, y;
            for ( x=0 , y = 0; x <500 && y<100 ; x += 10)
            {
                Helper.PostMessage(Child2, (int)WM.WM_MOUSEMOVE, (int)WM.MK_LBUTTON, Helper.MAKELPARAM(pt.X + x, pt.Y + y));
                Thread.Sleep(100);
            }
            Helper.SendMessage(Child2, (int)WM.WM_LBUTTONUP, 0, Helper.MAKELPARAM(x, y));
        }
    }
}
