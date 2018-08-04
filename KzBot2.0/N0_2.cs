using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KzBot2
{
    public static class N0_2
    {
        public static void StartRun(int runs, string draggerType)
        {
            ScriptMethods.TakeFormationScreenShot();
            ScriptMethods.RestartLogis();

            ScriptMethods.TakeRepairScreenShot();
            ScriptMethods.RepairLoop();

            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.FormationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(3500, 4500));
            ScriptMethods.Echelon1ChangeUnit();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));

            if (draggerType == "RF")
                ScriptMethods.ChangeFilterRF();
            else if (draggerType == "AR")
                ScriptMethods.ChangeFilterAR();

            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            if (runs % 2 == 0)
                ScriptMethods.SelectUnit1();
            else
                ScriptMethods.SelectUnit3();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectEchelon2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            ScriptMethods.Echelon2ChangeUnit();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            if (runs % 2 == 0)
                ScriptMethods.SelectUnit3();
            else
                ScriptMethods.SelectUnit1();

            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.ReturnToBaseClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5000));

            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.ClickCombat();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 4000));

            ScriptMethods.SelectChapter0();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.Select0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.NormalBattleClick();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.DeployTeam1_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.DeployTeam2_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.StartOperationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5000));
            ScriptMethods.ResupplyEchelon1_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            ScriptMethods.SelectNode0_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode1_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.MouseDragTopToBottom();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.SelectNode2_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode3_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode4_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(140000, 142000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(14500, 15500));
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            ScriptMethods.SelectNode4_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode5_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode6_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(95500, 100000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(11500, 12000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(5000, 5500));
        }
    }
}
