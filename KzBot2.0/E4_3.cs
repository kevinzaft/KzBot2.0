using System;
using System.Configuration;
using System.Threading;

namespace KzBot2
{
    public static class E4_3
    {
        public static void StartRun(int runs, string draggerType)
        {
            var dragger1Slot = Int32.Parse(ConfigurationManager.AppSettings["dragger1_slot_43E"]);
            var dragger2Slot = Int32.Parse(ConfigurationManager.AppSettings["dragger2_slot_43E"]);
            var clearTime = Int32.Parse(ConfigurationManager.AppSettings["43E_cleartime"]);
            var clearTimeOffset = Int32.Parse(ConfigurationManager.AppSettings["clearTimeOffSet"]);

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

            if(draggerType == "RF")
                ScriptMethods.ChangeFilterRF();
            else if (draggerType == "AR")
                ScriptMethods.ChangeFilterAR();

            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            if (runs % 2 == 0)
                ScriptMethods.SelectUnit(dragger1Slot);
            else
                ScriptMethods.SelectUnit(dragger2Slot);
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectEchelon2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            ScriptMethods.Echelon2ChangeUnit();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            if (runs % 2 == 0)
                ScriptMethods.SelectUnit(dragger2Slot);
            else
                ScriptMethods.SelectUnit(dragger1Slot);

            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.ReturnToBaseClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5000));

            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.ClickCombat();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 4000));
            ScriptMethods.SelectChapter4();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectEmergency();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.Select4_3();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3000));
            ScriptMethods.NormalBattleClick();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.DeployTeam1();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.DeployTeam2();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.StartOperationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(5500, 6000));
            ScriptMethods.ResupplyEchelon1();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode1();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode3();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.MouseDragTopToBottom();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.SelectNode4();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode5();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(clearTime, clearTime+ clearTimeOffset));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(11500, 12500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(5000, 5500));
        }
    }
}
