﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace KzBot2
{
    public static class Helper
    {
//C++ imports
        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(int xPoirnt, int yPoint);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr parentHandel, IntPtr childAfter, String sClassName, String windowTitle);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);
//Helper Methods
        public static int MAKELPARAM(int x, int y)
        {
            return ((y << 16) | (x & 0xFFFF));
        }
        public static IntPtr FindNox(string name = "")
        {
            return FindWindow("Qt5QWindowIcon", name);
        }
        public static IntPtr FindNoxInnerScreen(string name = "")
        {
            IntPtr NoxhWnd = FindNox(name);
            IntPtr Child1 = FindWindowEx(NoxhWnd, IntPtr.Zero, null, "ScreenBoardClassWindow");
            IntPtr Child2 = FindWindowEx(Child1, IntPtr.Zero, null, "QWidgetClassWindow");
            return Child2;
        }
        public static Bitmap Screenshot(IntPtr hwnd)
        {
            GetWindowRect(hwnd, out RECT rc); //used the proccess ID to set the Screenshot rectangle area

            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppArgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            PrintWindow(hwnd, hdcBitmap, 0);

            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();

            return bmp;
        }
    }
    public enum WM : int
    {
        WM_MOUSEMOVE = 0x200,
        WM_LBUTTONDOWN = 0x201,
        WM_LBUTTONUP = 0X202,
        WM_LBUTTONCLICK = 0X203,
        WM_SETCURSOR = 0x0020,

        MK_LBUTTON = 0x0001
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public RECT(RECT Rectangle) : this(Rectangle.Left, Rectangle.Top, Rectangle.Right, Rectangle.Bottom)
        {
        }
        public RECT(int Left, int Top, int Right, int Bottom)
        {
            X = Left;
            Y = Top;
            this.Right = Right;
            this.Bottom = Bottom;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Left
        {
            get { return X; }
            set { X = value; }
        }
        public int Top
        {
            get { return Y; }
            set { Y = value; }
        }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public int Height
        {
            get { return Bottom - Y; }
            set { Bottom = value + Y; }
        }
        public int Width
        {
            get { return Right - X; }
            set { Right = value + X; }
        }
        public Point Location
        {
            get { return new Point(Left, Top); }
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }
        public Size Size
        {
            get { return new Size(Width, Height); }
            set
            {
                Right = value.Width + X;
                Bottom = value.Height + Y;
            }
        }

        public static implicit operator Rectangle(RECT Rectangle)
        {
            return new Rectangle(Rectangle.Left, Rectangle.Top, Rectangle.Width, Rectangle.Height);
        }
        public static implicit operator RECT(Rectangle Rectangle)
        {
            return new RECT(Rectangle.Left, Rectangle.Top, Rectangle.Right, Rectangle.Bottom);
        }
        public static bool operator ==(RECT Rectangle1, RECT Rectangle2)
        {
            return Rectangle1.Equals(Rectangle2);
        }
        public static bool operator !=(RECT Rectangle1, RECT Rectangle2)
        {
            return !Rectangle1.Equals(Rectangle2);
        }

        public override string ToString()
        {
            return "{Left: " + X + "; " + "Top: " + Y + "; Right: " + Right + "; Bottom: " + Bottom + "}";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public bool Equals(RECT Rectangle)
        {
            return Rectangle.Left == X && Rectangle.Top == Y && Rectangle.Right == Right && Rectangle.Bottom == Bottom;
        }

        public override bool Equals(object Object)
        {
            if (Object is RECT)
            {
                return Equals((RECT)Object);
            }
            else if (Object is Rectangle)
            {
                return Equals(new RECT((Rectangle)Object));
            }

            return false;
        }
    }
}
//Point pt = new Point(229, 352);
//Point pt2 = new Point(187, 300);

//IntPtr NoxhWnd = Helper.FindWindow("Qt5QWindowIcon", null); //specify Nox Emulator name if multiple instances

////SetForegroundWindow(NoxhWnd);

//Thread.Sleep(2000);
//Helper.SendMessage(NoxhWnd, (int)Helper.WM.WM_LBUTTONDOWN, 1, Helper.MAKELPARAM(pt.X, pt.Y)); //SendMessage(handle, (int)WM.WM_LBUTTONUP, 1, MAKELPARAM(pt.X, pt.Y));
//Helper.SendMessage(NoxhWnd, (int)Helper.WM.WM_MOUSEMOVE, 0, Helper.MAKELPARAM(pt.X, pt.Y));

//Thread.Sleep(1000);
//Helper.SendMessage(NoxhWnd, (int)Helper.WM.WM_LBUTTONDOWN, 1, Helper.MAKELPARAM(pt2.X, pt2.Y));
//Helper.SendMessage(NoxhWnd, (int)Helper.WM.WM_MOUSEMOVE, 0, Helper.MAKELPARAM(pt2.X, pt2.Y));

//bool equal = ImageComparer.Compare(actual, expected);
