using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;

namespace KzBot2
{
    public static class N1_4
    {
        public static void StartRun()
        {
            var clearTimeOffset = Int32.Parse(ConfigurationManager.AppSettings["clearTimeOffSet"]);
            var turn1ClearTime = Int32.Parse(ConfigurationManager.AppSettings["14night_turn1_cleartime"]);
            var enemyAssault1ClearTime = Int32.Parse(ConfigurationManager.AppSettings["14night_enemy_assault1_cleartime"]);
            var turn2Kill = Int32.Parse(ConfigurationManager.AppSettings["14night_turn2_kill_cleartime"]);

            ScriptMethods.UpdateCurrentAction("Logistic returned check");
            ScriptMethods.TakeFormationScreenShot();
            ScriptMethods.RestartLogis();

            ScriptMethods.UpdateCurrentAction("Require repairs check");
            ScriptMethods.TakeRepairScreenShot();
            ScriptMethods.RepairLoop();

            ScriptMethods.UpdateCurrentAction("Logistic returned check");
            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.UpdateCurrentAction("Selecting 1-4N");
            ScriptMethods.ClickCombat();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 4000));
            ScriptMethods.SelectChapter1();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNight();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.Select3_4();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3000));
            ScriptMethods.NormalBattleClick();
            Thread.Sleep(ScriptMethods.randomize.Next(5000, 5500));
            ScriptMethods.UpdateCurrentAction("Deploying team 1");
            ScriptMethods.DeployTeam1_1_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.UpdateCurrentAction("Start operation click");
            ScriptMethods.StartOperationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(600, 6500));
            ScriptMethods.CloseNightBattleHint();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.UpdateCurrentAction("Turn 1 planning");
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode1_1_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode2_1_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode3_1_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.UpdateCurrentAction("Executing part 1 plan");
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(turn1ClearTime, turn1ClearTime + clearTimeOffset));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(enemyAssault1ClearTime, enemyAssault1ClearTime + clearTimeOffset));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(8500, 9000));

            ScriptMethods.UpdateCurrentAction("Deploying team 2");
            ScriptMethods.DeployTeam1_1_4N();
            ScriptMethods.UpdateCurrentAction("Turn 2 kill");
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5500));
            ScriptMethods.SelectNode3_1_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode4_1_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(turn2Kill, turn2Kill + clearTimeOffset));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(8500, 9000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(enemyAssault1ClearTime, enemyAssault1ClearTime + clearTimeOffset));

            ScriptMethods.UpdateCurrentAction("Turn 3 planning");
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode1_1_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode2_1_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode5_1_4N();
        }
    }
}
