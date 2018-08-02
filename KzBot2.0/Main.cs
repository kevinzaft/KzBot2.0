using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UITesting;
namespace KzBot2
{
    public partial class Main : Form
    {
        public String SelectedMap = "";
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetRuns();
            SelectedMap = "4-3E";
            FormProvider.RunManagerForm.Text = "Running " + SelectedMap;
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetRuns();
            SelectedMap = "0-2";
            FormProvider.RunManagerForm.Text = "Running " + SelectedMap;
        }

        private void GetRuns()
        {
            FormProvider.InputForm.Show();
            this.Hide();
        }
    }
}
