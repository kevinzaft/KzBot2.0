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
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.Echelon1ChangeUnit();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));

            if (draggerType == "RF")
                ScriptMethods.ChangeFilterRF();
            else if (draggerType == "AR")
                ScriptMethods.ChangeFilterAR();

            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2000));

            if (runs % 2 == 0)
                ScriptMethods.SelectUnit1();
            else
                ScriptMethods.SelectUnit3();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2000));
            ScriptMethods.SelectEchelon2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2000));

            ScriptMethods.Echelon2ChangeUnit();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            if (runs % 2 == 0)
                ScriptMethods.SelectUnit3();
            else
                ScriptMethods.SelectUnit1();

            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.ReturnToBaseClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4000, 4500));

            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.ClickCombat();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 4000));

            ScriptMethods.SelectChapter0();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 3000));
            ScriptMethods.Select0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.NormalBattleClick();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 4000));
            ScriptMethods.DeployTeam1_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.DeployTeam2_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.StartOperationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4000, 4500));
            ScriptMethods.ResupplyEchelon1_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));

            ScriptMethods.SelectNode0_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode1_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.MouseDragTopToBottom();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.SelectNode2_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode3_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode4_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(140000, 142000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(14000, 15000));
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));

            ScriptMethods.SelectNode4_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode5_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode6_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));

            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(95000, 100000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(11000, 12000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4000, 5000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4000, 4500));
        }
    }
}
