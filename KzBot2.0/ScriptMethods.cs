﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

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
            Helper.SendMessage(Nox, (int)WM.WM_LBUTTONDOWN, (int)WM.MK_LBUTTON, Helper.MAKELPARAM((int)(pt.X *((double)Helper.GetNoxRes().Width/1284)), (int)(pt.Y * ((double)Helper.GetNoxRes().Height / 752))));
            Helper.SendMessage(Nox, (int)WM.WM_MOUSEMOVE, 0, Helper.MAKELPARAM((int)(pt.X * ((double)Helper.GetNoxRes().Width / 1284)), (int)(pt.Y * ((double)Helper.GetNoxRes().Height / 752))));
            Helper.SendMessage(Nox, (int)WM.WM_LBUTTONUP, (int)WM.MK_LBUTTON, Helper.MAKELPARAM((int)(pt.X * ((double)Helper.GetNoxRes().Width / 1284)), (int)(pt.Y * ((double)Helper.GetNoxRes().Height / 752))));
        }
        public static void DragRange(int x1, int y1, int x2, int y2, int xx1, int yy1, int xx2, int yy2)
        {
            var pt1 = new Point(randomize.Next(x1, x2), randomize.Next(y1, y2));
            var pt2 = new Point(randomize.Next(xx1, xx2), randomize.Next(yy1, yy2));
            var mainDragDirection = Math.Abs(pt1.X - pt2.X) > Math.Abs(pt1.Y - pt2.Y) ? "x" : "y";

            Helper.SendMessage(NoxChild, (int)WM.WM_LBUTTONDOWN, (int)WM.MK_LBUTTON, Helper.MAKELPARAM((int)(pt1.X * ((double)Helper.GetNoxInnerRes().Width / 1280)), (int)(pt1.Y * ((double)Helper.GetNoxInnerRes().Height / 720))));

            if (mainDragDirection.Equals("x"))
            {
                for (int x = pt1.X, y = pt1.Y; x < pt2.X; x += 10)
                {
                    y = y < pt2.Y ? y + 5 : y;
                    Helper.SendMessage(NoxChild, (int)WM.WM_MOUSEMOVE, (int)WM.MK_LBUTTON, Helper.MAKELPARAM((int)(x * ((double)Helper.GetNoxInnerRes().Width / 1280)), (int)(y * ((double)Helper.GetNoxInnerRes().Height / 720))));
                    Thread.Sleep(50);
                }
            }
            else
            {
                for (int x = pt1.X, y = pt1.Y; y < pt2.Y; y += 10)
                {
                    x = x < pt2.X ? x + 5 : x;
                    Helper.SendMessage(NoxChild, (int)WM.WM_MOUSEMOVE, (int)WM.MK_LBUTTON, Helper.MAKELPARAM((int)(x * ((double)Helper.GetNoxInnerRes().Width / 1280)), (int)(y * ((double)Helper.GetNoxInnerRes().Height / 720))));
                    Thread.Sleep(50);
                }
            }
            Helper.SendMessage(NoxChild, (int)WM.WM_LBUTTONUP, 0, Helper.MAKELPARAM((int)(pt2.X * ((double)Helper.GetNoxInnerRes().Width / 1280)), (int)(pt2.Y * ((double)Helper.GetNoxInnerRes().Height / 720))));
        }

        public static void UpdateCurrentAction(String s)
        {
            FormProvider.MainForm.Invoke(new MethodInvoker(() =>
            {
                FormProvider.RunManagerForm.label3.Text = s;
            }));
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

        public static void SelectUnit(int slot)
        {
            switch (slot)
            {
                case 1:
                    SelectUnit1();
                    break;
                case 2:
                    SelectUnit2();
                    break;
                case 3:
                    SelectUnit3();
                    break;
                case 4:
                    SelectUnit4();
                    break;
                case 5:
                    SelectUnit5();
                    break;
            }
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

        public static void SelectChapter1()
        {
            ClickRange(210, 240, 320, 320);
        }

        public static void SelectChapter3()
        {
            ClickRange(210, 450, 320, 515);
        }

        public static void SelectEmergency()
        {
            ClickRange(1065, 205, 1135, 225);
        }

        public static void SelectNight()
        {
            ClickRange(1170, 205, 1260, 225);
        }

        public static void Select4_3()
        {
            ClickRange(420, 500, 1265, 590);
        }

        public static void Select0_2()
        {
            ClickRange(420, 385, 1265, 470);
        }

        public static void Select3_4()
        {
            ClickRange(420, 620, 1265, 705);
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
            Thread.Sleep(randomize.Next(2000, 3000));
            Ok_Execute_End_ButtonClick();
        }

        public static void DeployTeam2()
        {
            ClickRange(1040, 480, 1111, 555);
            Thread.Sleep(randomize.Next(2000, 3000));
            Ok_Execute_End_ButtonClick();
        }

        public static void DeployTeam1_0_2()
        {
            ClickRange(222, 344, 305, 416);
            Thread.Sleep(randomize.Next(2000, 3000));
            Ok_Execute_End_ButtonClick();
        }

        public static void DeployTeam2_0_2()
        {
            ClickRange(620, 350, 705, 425);
            Thread.Sleep(randomize.Next(2000, 3000));
            Ok_Execute_End_ButtonClick();
        }

        public static void DeployTeam_3_4N()
        {
            ClickRange(965, 169, 1030, 230);
            Thread.Sleep(randomize.Next(2000, 3000));
            Ok_Execute_End_ButtonClick();
        }

        public static void DeployTeam1_1_4N()
        {
            ClickRange(200, 410, 265, 460);
            Thread.Sleep(randomize.Next(2000, 3000));
            Ok_Execute_End_ButtonClick();
        }
        public static void CloseNightBattleHint()
        {
            ClickRange(170, 140, 265, 185);
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
            Thread.Sleep(randomize.Next(20, 30));
            ClickRange(188, 355, 255, 435);
            Thread.Sleep(randomize.Next(2500, 3000));
            ResupplyClick();
        }

        public static void ResupplyEchelon1_0_2()
        {
            ClickRange(222, 344, 305, 416);
            Thread.Sleep(randomize.Next(15, 20));
            ClickRange(222, 344, 305, 416);
            Thread.Sleep(randomize.Next(2500, 3000));
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

        public static void MouseDragBottomToTop()
        {
            DragRange(820, 710, 1120, 710, 1130, 20, 1270, 20);
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
            Thread.Sleep(randomize.Next(1500, 2000));
            ClickRange(900, 390, 1060, 460);
            Thread.Sleep(randomize.Next(2000, 3000));
            SelectUnit1();
        }

        public static void ChangeFilterAR()
        {
            ClickRange(1110, 270, 1250, 355);
            Thread.Sleep(randomize.Next(1500, 2000));
            ClickRange(535, 480, 700, 545);
            Thread.Sleep(randomize.Next(2000, 3000));
            SelectUnit1();
        }

        public static void ChangeFilterMG()
        {
            ClickRange(1110, 270, 1250, 355);
            Thread.Sleep(randomize.Next(1500, 2000));
            ClickRange(720, 485, 875, 545);
            Thread.Sleep(randomize.Next(2000, 3000));
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
            ClickRange(505, 270, 540, 300);
        }

        public static void SelectNode5_0_2()
        {
            ClickRange(785, 270, 835, 310);
        }

        public static void SelectNode6_0_2()
        {
            ClickRange(965, 295, 1025, 355);
        }

        public static void SelectNode1_3_4N()
        {
            ClickRange(975, 182, 1020, 215);
        }

        public static void SelectNode2_3_4N()
        {
            ClickRange(805, 390, 840, 420);
        }

        public static void SelectNode3_3_4N()
        {
            ClickRange(840, 610, 875, 640);
        }

        public static void SelectNode4_3_4N()
        {

        }

        public static void SelectNode5_3_4N()
        {

        }

        public static void SelectNode6_3_4N()
        {

        }

        public static void SelectNode1_1_4N()
        {
            ClickRange(200, 350, 265, 450);
        }

        public static void SelectNode2_1_4N()
        {
            ClickRange(415, 500, 444, 545);
        }

        public static void SelectNode3_1_4N()
        {
            ClickRange(688, 320, 720, 363);
        }

        public static void SelectNode4_1_4N()
        {
            ClickRange(495, 363, 530, 395);
        }

        public static void SelectNode5_1_4N()
        {
            ClickRange(255, 720, 310, 745);
        }

        public static void SupportEchelonClick()
        {
            ClickRange(5, 460, 115, 515);
        }

        public static void DeployFriendSupport(bool UseGriffin)
        {
            if (UseGriffin)
                ClickRange(200,180,1100,280);
            else
                ClickRange(200, 320, 1100, 420);
            Thread.Sleep(randomize.Next(2000, 3000));
            Ok_Execute_End_ButtonClick();
        }

        public static void ChangeFriendModeEliminate()
        {
            DeployTeam_3_4N(); //just using this b/c the coords are already mapped
            Thread.Sleep(randomize.Next(1500, 2000));
            DeployTeam_3_4N();
            Thread.Sleep(randomize.Next(2000, 3000));
            ClickRange(780,210,915,250);
            Thread.Sleep(randomize.Next(2000, 3000));
            ClickRange(90, 180, 250, 250);//clicking somewhere blank just incase
        }

        public static void RestartLogis()
        {
            while (!Helper.CompareMemCmp(formationButtonCurrent, formationButtonDefault))
            {
                Thread.Sleep(randomize.Next(4500, 5000));
                SelectRepairSlot();
                Thread.Sleep(randomize.Next(1000, 1500));
                RepeatLogisticConfirmClick();
                Thread.Sleep(randomize.Next(5500, 6000));
                TakeFormationScreenShot();
            }
        }

        public static void RepairLoop()
        {
            while (!Helper.CompareMemCmp(repairButtonCurrent, repairButtonDefault))
            {
                RepaireButtonClick();
                Thread.Sleep(randomize.Next(3000, 4500));
                SelectRepairSlot();
                Thread.Sleep(randomize.Next(2000, 2500));
                SelectRepairDoll();
                Thread.Sleep(randomize.Next(1500, 2000));
                RepairOkClick();
                Thread.Sleep(randomize.Next(1500, 2000));
                SelectQuickRepair();
                Thread.Sleep(randomize.Next(1500, 2000));
                RepairResourceCostOkClick();
                Thread.Sleep(randomize.Next(2500, 3000));
                ReturnToBaseClick();
                Thread.Sleep(randomize.Next(2500, 3000));
                ReturnToBaseClick();
                Thread.Sleep(randomize.Next(6000, 6500));
                TakeRepairScreenShot();
            }
        }

        public static void TakeRepairScreenShot()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Screenshots\\repairButtonCurrent.jpg"))
                System.IO.File.Delete(Environment.CurrentDirectory + "\\Screenshots\\repairButtonCurrent.jpg");

            var ss = Helper.Screenshot(Helper.FindNox()).Clone(new Rectangle((int)(835 * ((double)Helper.GetNoxRes().Width / 1284)), (int)(265 * ((double)Helper.GetNoxRes().Height / 752)), (int)(180 * ((double)Helper.GetNoxRes().Width / 1284)), (int)(65 * ((double)Helper.GetNoxRes().Height / 752))), PixelFormat.DontCare);
            //var temp = new Bitmap(ss.Clone(new Rectangle(835, 265, 180, 65), ss.PixelFormat));
            ss.Save(Environment.CurrentDirectory + "\\Screenshots\\repairButtonCurrent.jpg");
            ss.Dispose();
            //temp.Dispose();
        }

        public static void TakeFormationScreenShot()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Screenshots\\formationButtonCurrent.jpg"))
                System.IO.File.Delete(Environment.CurrentDirectory + "\\Screenshots\\formationButtonCurrent.jpg");

            var ss = Helper.Screenshot(Helper.FindNox()).Clone(new Rectangle((int)(1050 * ((double)Helper.GetNoxRes().Width / 1284)), (int)(440 * ((double)Helper.GetNoxRes().Height / 752)), (int)(210 * ((double)Helper.GetNoxRes().Width / 1284)), (int)(90 * ((double)Helper.GetNoxRes().Height / 752))), PixelFormat.DontCare);
            //var temp = new Bitmap(ss.Clone(new Rectangle(1050, 440, 210, 90), ss.PixelFormat));
            ss.Save(Environment.CurrentDirectory + "\\Screenshots\\formationButtonCurrent.jpg");
            ss.Dispose();
            //temp.Dispose();
        }

        public static void TakeRepairScreenShotDefault()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Screenshots\\repairButtonDefault.jpg"))
                System.IO.File.Delete(Environment.CurrentDirectory + "\\Screenshots\\repairButtonDefault.jpg");

            var ss = Helper.Screenshot(Helper.FindNox()).Clone(new Rectangle((int)(835 * ((double)Helper.GetNoxRes().Width / 1284)), (int)(265 * ((double)Helper.GetNoxRes().Height / 752)), (int)(180 * ((double)Helper.GetNoxRes().Width / 1284)), (int)(65 * ((double)Helper.GetNoxRes().Height / 752))), PixelFormat.DontCare);
            //var temp = new Bitmap(ss.Clone(new Rectangle(835, 265, 180, 65), ss.PixelFormat));
            ss.Save(Environment.CurrentDirectory + "\\Screenshots\\repairButtonDefault.jpg");
            ss.Dispose();
            //temp.Dispose();
        }

        public static void TakeFormationScreenShotDefault()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Screenshots\\formationButtonDefault.jpg"))
                System.IO.File.Delete(Environment.CurrentDirectory + "\\Screenshots\\formationButtonDefault.jpg");

            var ss = Helper.Screenshot(Helper.FindNox()).Clone(new Rectangle((int)(1050 * ((double)Helper.GetNoxRes().Width / 1284)), (int)(440 * ((double)Helper.GetNoxRes().Height / 752)), (int)(210 * ((double)Helper.GetNoxRes().Width / 1284)), (int)(90 * ((double)Helper.GetNoxRes().Height / 752))), PixelFormat.DontCare);
            //var temp = new Bitmap(ss.Clone(new Rectangle(1050, 440, 210, 90), ss.PixelFormat));
            ss.Save(Environment.CurrentDirectory + "\\Screenshots\\formationButtonDefault.jpg");
            ss.Dispose();
            //temp.Dispose();
        }
    }
}
