using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KzBot2
{
    public static class E4_3
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

            if(draggerType == "RF")
                ScriptMethods.ChangeFilterRF();
            else if (draggerType == "AR")
                ScriptMethods.ChangeFilterAR();

            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2000));

            if (runs % 2 == 0)
                ScriptMethods.SelectUnit1();
            else
                ScriptMethods.SelectUnit2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2000));
            ScriptMethods.SelectEchelon2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2000));

            ScriptMethods.Echelon2ChangeUnit();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            if (runs % 2 == 0)
                ScriptMethods.SelectUnit2();
            else
                ScriptMethods.SelectUnit1();

            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.ReturnToBaseClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4000, 4500));

            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.ClickCombat();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 4000));
            ScriptMethods.SelectChapter4();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectEmergency();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 3000));
            ScriptMethods.Select4_3();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.NormalBattleClick();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 4000));
            ScriptMethods.DeployTeam1();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.DeployTeam2();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.StartOperationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4000, 4500));
            ScriptMethods.ResupplyEchelon1();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode1();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode2();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode3();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.MouseDragTopToBottom();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.SelectNode4();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.SelectNode5();
            Thread.Sleep(ScriptMethods.randomize.Next(1000, 2500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(130000, 135000));
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
