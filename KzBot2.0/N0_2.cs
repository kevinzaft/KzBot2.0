using System;
using System.Configuration;
using System.Threading;

namespace KzBot2
{
    public static class N0_2
    {
        public static void StartRun(int runs, string draggerType)
        {
            var dragger1Slot = Int32.Parse(ConfigurationManager.AppSettings["dragger1_slot_02E"]);
            var dragger2Slot = Int32.Parse(ConfigurationManager.AppSettings["dragger2_slot_02E"]);
            var clearTimePart1 = Int32.Parse(ConfigurationManager.AppSettings["02N_Part1_cleartime"]);
            var clearTimePart2 = Int32.Parse(ConfigurationManager.AppSettings["02N_Part2_cleartime"]);
            var clearTimeOffset = Int32.Parse(ConfigurationManager.AppSettings["clearTimeOffSet"]);

            ScriptMethods.UpdateCurrentAction("Logistic returned check");
            ScriptMethods.TakeFormationScreenShot();
            ScriptMethods.RestartLogis();

            ScriptMethods.UpdateCurrentAction("Require repairs check");
            ScriptMethods.TakeRepairScreenShot();
            ScriptMethods.RepairLoop();

            ScriptMethods.UpdateCurrentAction("Logistic returned check");
            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.UpdateCurrentAction("Changing draggers");
            ScriptMethods.FormationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(3500, 4500));
            ScriptMethods.Echelon1ChangeUnit();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
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

            ScriptMethods.UpdateCurrentAction("Logistic returned check");
            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.UpdateCurrentAction("Selecting 0-2");
            ScriptMethods.ClickCombat();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 4000));
            ScriptMethods.SelectChapter0();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.Select0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3000));
            ScriptMethods.NormalBattleClick();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.UpdateCurrentAction("Deploying team 1");
            ScriptMethods.DeployTeam1_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.UpdateCurrentAction("Deploying team 2");
            ScriptMethods.DeployTeam2_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.UpdateCurrentAction("Start operation click");
            ScriptMethods.StartOperationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5000));
            ScriptMethods.UpdateCurrentAction("Resupply team 1");
            ScriptMethods.ResupplyEchelon1_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));

            ScriptMethods.UpdateCurrentAction("Part 1 planning");
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
            ScriptMethods.UpdateCurrentAction("Executing part 1 plan");

            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(clearTimePart1, clearTimePart1 + clearTimeOffset));
            ScriptMethods.UpdateCurrentAction("Part 1 cleared, waiting for turn 2");
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(15500, 16500));

            ScriptMethods.UpdateCurrentAction("Part 2 planning");
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode4_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode5_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode6_0_2();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            ScriptMethods.UpdateCurrentAction("Executing part 2 plan");
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(clearTimePart2, clearTimePart2 + clearTimeOffset));
            ScriptMethods.UpdateCurrentAction("Part 2 cleared, existing to main screen");
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
