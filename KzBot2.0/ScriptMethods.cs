using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace KzBot2
{
    static class ScriptMethods
    {
        public static Random randomize;
        public static IntPtr Nox;
        public static IntPtr NoxChild;
        public static readonly string repairButtonCurrent;
        public static readonly string formationButtonCurrent;
        public static readonly string repairButtonDefault;
        public static readonly string formationButtonDefault;
        static ScriptMethods()
        {
            randomize = new Random();
            Nox = Helper.FindNox();
            NoxChild = Helper.FindNoxInnerScreen();
            repairButtonCurrent = Environment.CurrentDirectory + "\\Screenshots\\repairButtonCurrent.jpg";
            formationButtonCurrent = Environment.CurrentDirectory + "\\Screenshots\\formationButtonCurrent.jpg";

            repairButtonDefault = Environment.CurrentDirectory + "\\Screenshots\\repairButtonDefault.jpg";
            formationButtonDefault = Environment.CurrentDirectory + "\\Screenshots\\formationButtonDefault.jpg";
        }

        public static void ClickRange(int x1, int y1, int x2, int y2)
        {
            Point pt = new Point(randomize.Next(x1, x2), randomize.Next(y1, y2));
            Helper.SendMessage(Nox, (int)WM.WM_LBUTTONDOWN, (int)WM.MK_LBUTTON, Helper.MAKELPARAM(pt.X, pt.Y));
            Helper.SendMessage(Nox, (int)WM.WM_MOUSEMOVE, 0, Helper.MAKELPARAM(pt.X, pt.Y));
            Helper.SendMessage(Nox, (int)WM.WM_LBUTTONUP, (int)WM.MK_LBUTTON, Helper.MAKELPARAM(pt.X, pt.Y));
        }
        public static void DragRange(int x1, int y1, int x2, int y2, int xx1, int yy1, int xx2, int yy2)
        {
            var pt1 = new Point(randomize.Next(x1, x2), randomize.Next(y1, y2));
            var pt2 = new Point(randomize.Next(xx1, xx2), randomize.Next(yy1, yy2));
            var mainDragDirection = Math.Abs(pt1.X - pt2.X) > Math.Abs(pt1.Y - pt2.Y) ? "x" : "y";

            Helper.SendMessage(NoxChild, (int)WM.WM_LBUTTONDOWN, (int)WM.MK_LBUTTON, Helper.MAKELPARAM(pt1.X, pt1.Y));

            if (mainDragDirection.Equals("x"))
            {
                for (int x = pt1.X, y = pt1.Y; x < pt2.X; x += 10)
                {
                    y = y < pt2.Y ? y + 5 : y;
                    Helper.SendMessage(NoxChild, (int)WM.WM_MOUSEMOVE, (int)WM.MK_LBUTTON, Helper.MAKELPARAM(x, y));
                    Thread.Sleep(50);
                }
            }
            else
            {
                for (int x = pt1.X, y = pt1.Y; y < pt2.Y; y += 10)
                {
                    x = x < pt2.X ? x + 5 : x;
                    Helper.SendMessage(NoxChild, (int)WM.WM_MOUSEMOVE, (int)WM.MK_LBUTTON, Helper.MAKELPARAM(x, y));
                    Thread.Sleep(50);
                }
            }
            Helper.SendMessage(NoxChild, (int)WM.WM_LBUTTONUP, 0, Helper.MAKELPARAM(pt2.X, pt2.Y));
        }

        //______________________________________________________________________________________________________________

        public static void FormationClick()
        {
            ClickRange(1050, 440, 1260, 530);
        }

        public static void Echelon1ChangeUnit()
        {
            ClickRange(150, 150, 315, 550);
        }

        public static void SelectUnit1()
        {
            ClickRange(200, 145, 355, 425);
        }

        public static void SelectUnit2()
        {
            ClickRange(375, 145, 535, 425);
        }

        public static void SelectUnit3()
        {
            ClickRange(560, 145, 705, 425);
        }

        public static void SelectUnit4()
        {
            ClickRange(735, 145, 885, 425);
        }

        public static void SelectUnit5()
        {
            ClickRange(915, 145, 1065, 425);
        }

        public static void SelectEchelon2()
        {
            ClickRange(20, 225, 120, 290);
        }

        public static void Echelon2ChangeUnit()
        {
            ClickRange(885, 150, 1050, 550);
        }

        public static void ReturnToBaseClick()
        {
            ClickRange(15, 35, 135, 120);
        }

        public static void ClickCombat()
        {
            ClickRange(820, 450, 1030, 550);
        }

        public static void SelectChapter4()
        {
            ClickRange(210, 540, 320, 625);
        }

        public static void SelectChapter0()
        {
            ClickRange(210, 150, 320, 215);
        }

        public static void SelectEmergency()
        {
            ClickRange(1065, 205, 1135, 225);
        }

        public static void Select4_3()
        {
            ClickRange(420, 500, 1265, 590);
        }

        public static void Select0_2()
        {
            ClickRange(420, 385, 1265, 470);
        }

        public static void NormalBattleClick()
        {
            ClickRange(673, 575, 826, 645);
        }

        public static void Ok_Execute_End_ButtonClick()
        {
            ClickRange(1100, 654, 1260, 710);
        }

        public static void DeployTeam1()
        {
            ClickRange(188, 355, 255, 435);
            Thread.Sleep(randomize.Next(1500, 2500));
            Ok_Execute_End_ButtonClick();
        }

        public static void DeployTeam2()
        {
            ClickRange(1040, 480, 1111, 555);
            Thread.Sleep(randomize.Next(1500, 2500));
            Ok_Execute_End_ButtonClick();
        }

        public static void DeployTeam1_0_2()
        {
            ClickRange(222, 344, 305, 416);
            Thread.Sleep(randomize.Next(1500, 2500));
            Ok_Execute_End_ButtonClick();
        }

        public static void DeployTeam2_0_2()
        {
            ClickRange(620, 350, 705, 425);
            Thread.Sleep(randomize.Next(1500, 2500));
            Ok_Execute_End_ButtonClick();
        }

        public static void StartOperationClick()
        {
            ClickRange(1000, 635, 1260, 720);
        }

        public static void ResupplyClick()
        {
            ClickRange(1090, 565, 1280, 620);
        }

        public static void ResupplyEchelon1()
        {
            ClickRange(188, 355, 255, 435);
            Thread.Sleep(randomize.Next(15, 20));
            ClickRange(188, 355, 255, 435);
            Thread.Sleep(randomize.Next(1500, 2500));
            ResupplyClick();
        }

        public static void ResupplyEchelon1_0_2()
        {
            ClickRange(222, 344, 305, 416);
            Thread.Sleep(randomize.Next(15, 20));
            ClickRange(222, 344, 305, 416);
            Thread.Sleep(randomize.Next(1500, 2500));
            ResupplyClick();
        }

        public static void PlanningModeClick()
        {
            ClickRange(10, 600, 150, 640);
        }

        public static void MouseDragTopToBottom()
        {
            DragRange(1130, 20, 1270, 20, 820, 710, 1120, 710);
        }

        public static void SelectNode1()
        {
            ClickRange(1040, 480, 1111, 555);
        }

        public static void SelectNode2()
        {
            ClickRange(1045, 345, 1085, 380);
        }

        public static void SelectNode3()
        {
            ClickRange(1100, 180, 1145, 225);
        }

        public static void SelectNode4()
        {
            ClickRange(1010, 460, 1050, 495);
        }

        public static void SelectNode5()
        {
            ClickRange(1015, 237, 1075, 290);
        }

        public static void RepaireButtonClick()
        {
            ClickRange(835, 265, 1015, 330);
        }

        public static void SelectRepairSlot()
        {
            ClickRange(50, 179, 770, 690);
        }

        public static void SelectRepairDoll()
        {
            ClickRange(20, 145, 170, 420);
        }

        public static void RepairOkClick()
        {
            ClickRange(1100, 530, 1265, 630);
        }

        public static void SelectQuickRepair()
        {
            ClickRange(285, 505, 350, 565);
        }

        public static void RepairResourceCostOkClick()
        {
            ClickRange(845, 505, 1010, 565);
        }

        public static void RepeatLogisticConfirmClick()
        {
            ClickRange(670, 495, 830, 555);
        }

        public static void ChangeFilterRF()
        {
            ClickRange(1110, 270, 1250, 355);
            Thread.Sleep(randomize.Next(1000, 1500));
            ClickRange(900, 390, 1060, 460);
            Thread.Sleep(randomize.Next(1500, 2500));
            SelectUnit1();
        }

        public static void ChangeFilterAR()
        {
            ClickRange(1110, 270, 1250, 355);
            Thread.Sleep(randomize.Next(1000, 1500));
            ClickRange(535, 480, 700, 545);
            Thread.Sleep(randomize.Next(1500, 2500));
            SelectUnit1();
        }

        public static void ChangeFilterMG()
        {
            ClickRange(1110, 270, 1250, 355);
            Thread.Sleep(randomize.Next(1000, 1500));
            ClickRange(720, 485, 875, 545);
            Thread.Sleep(randomize.Next(1500, 2500));
            SelectUnit1();
        }

        public static void SelectNode0_0_2()
        {
            ClickRange(620, 350, 700, 425);
        }

        public static void SelectNode1_0_2()
        {
            ClickRange(475, 275, 525, 310);
        }

        public static void SelectNode2_0_2()
        {
            ClickRange(505, 565, 565, 610);
        }

        public static void SelectNode3_0_2()
        {
            ClickRange(650, 365, 695, 405);
        }

        public static void SelectNode4_0_2()
        {
            ClickRange(500, 270, 550, 305);
        }

        public static void SelectNode5_0_2()
        {
            ClickRange(785, 270, 835, 310);
        }

        public static void SelectNode6_0_2()
        {
            ClickRange(965, 295, 1025, 355);
        }


        public static void RestartLogis()
        {
            while (!Helper.CompareMemCmp(formationButtonCurrent, formationButtonDefault))
            {
                Thread.Sleep(randomize.Next(4000, 4500));
                SelectRepairSlot();
                Thread.Sleep(randomize.Next(500, 1000));
                RepeatLogisticConfirmClick();
                Thread.Sleep(randomize.Next(3500, 4000));
                TakeFormationScreenShot();
            }
        }

        public static void RepairLoop()
        {
            while (!Helper.CompareMemCmp(repairButtonCurrent, repairButtonDefault))
            {
                RepaireButtonClick();
                Thread.Sleep(randomize.Next(2500, 4000));
                SelectRepairSlot();
                Thread.Sleep(randomize.Next(1500, 2000));
                SelectRepairDoll();
                Thread.Sleep(randomize.Next(1000, 1500));
                RepairOkClick();
                Thread.Sleep(randomize.Next(1000, 1500));
                SelectQuickRepair();
                Thread.Sleep(randomize.Next(1000, 1500));
                RepairResourceCostOkClick();
                Thread.Sleep(randomize.Next(1500, 2000));
                ReturnToBaseClick();
                Thread.Sleep(randomize.Next(500, 1000));
                ReturnToBaseClick();
                Thread.Sleep(randomize.Next(3500, 4000));
                TakeFormationScreenShot();
            }
        }

        public static void TakeRepairScreenShot()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Screenshots\\repairButtonCurrent.jpg"))
                System.IO.File.Delete(Environment.CurrentDirectory + "\\Screenshots\\repairButtonCurrent.jpg");

            var ss = new Bitmap(Helper.Screenshot(Helper.FindNox()));
            var temp = new Bitmap(ss.Clone(new Rectangle(835, 265, 180, 65), ss.PixelFormat));
            temp.Save(Environment.CurrentDirectory + "\\Screenshots\\repairButtonCurrent.jpg");
            ss.Dispose();
            temp.Dispose();
        }

        public static void TakeFormationScreenShot()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Screenshots\\formationButtonCurrent.jpg"))
                System.IO.File.Delete(Environment.CurrentDirectory + "\\Screenshots\\formationButtonCurrent.jpg");

            var ss = new Bitmap(Helper.Screenshot(Helper.FindNox()));
            var temp = new Bitmap(ss.Clone(new Rectangle(1050, 440, 210, 90), ss.PixelFormat));
            temp.Save(Environment.CurrentDirectory + "\\Screenshots\\formationButtonCurrent.jpg");
            ss.Dispose();
            temp.Dispose();
        }
    }
}
