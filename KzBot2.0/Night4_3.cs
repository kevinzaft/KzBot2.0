using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;

namespace KzBot2
{
    public static class Night4_3
    {
        public static void StartRun()
        {
            var node1Cleartime = Int32.Parse(ConfigurationManager.AppSettings["34Night_First_Node_Cleartime"]);
            var node2Cleartime = Int32.Parse(ConfigurationManager.AppSettings["34Night_Second_Node_Cleartime"]);
            var clearTimeOffset = Int32.Parse(ConfigurationManager.AppSettings["clearTimeOffSet"]);
            var unusedTeams = Int32.Parse(ConfigurationManager.AppSettings["34Night_Unused_Teams"]);
            var useGriffinSupport = Convert.ToBoolean(ConfigurationManager.AppSettings["34Night_Use_Griffin_Support"]);

            ScriptMethods.UpdateCurrentAction("Logistic returned check");
            ScriptMethods.TakeFormationScreenShot();
            ScriptMethods.RestartLogis();

            ScriptMethods.UpdateCurrentAction("Require repairs check");
            ScriptMethods.TakeRepairScreenShot();
            ScriptMethods.RepairLoop();

            ScriptMethods.UpdateCurrentAction("Logistic returned check");
            ScriptMethods.TakeFormationScreenShot(); //incase took too long and another logi came back
            ScriptMethods.RestartLogis();

            ScriptMethods.UpdateCurrentAction("Selecting 3-4N");
            ScriptMethods.ClickCombat();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 4000));
            ScriptMethods.SelectChapter3();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNight();
            Thread.Sleep(ScriptMethods.randomize.Next(2000, 3000));
            ScriptMethods.Select3_4();
            Thread.Sleep(ScriptMethods.randomize.Next(2500, 3000));
            ScriptMethods.NormalBattleClick();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.UpdateCurrentAction("Deploying team 1");
            ScriptMethods.DeployTeam_3_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.UpdateCurrentAction("Start operation click");
            ScriptMethods.StartOperationClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5000));
            ScriptMethods.CloseNightBattleHint();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));

            ScriptMethods.UpdateCurrentAction("Part 1 planning");
            ScriptMethods.PlanningModeClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode1_3_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode2_3_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.UpdateCurrentAction("Executing part 1 plan");
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(node1Cleartime, node1Cleartime + clearTimeOffset));
            ScriptMethods.DeployTeam_3_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.SupportEchelonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4000, 4500));
            ScriptMethods.DeployFriendSupport(useGriffinSupport);
            Thread.Sleep(ScriptMethods.randomize.Next(3000, 4000));
            ScriptMethods.ChangeFriendModeEliminate();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            //ScriptMethods.PlanningModeClick(); //apparently planning mode doesn't work with 1 point left
            //Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode2_3_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode3_3_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(node2Cleartime, node2Cleartime + clearTimeOffset));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(4500, 5500));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));

            //friend killing node
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(30000, 30000));
            ScriptMethods.Ok_Execute_End_ButtonClick();
            Thread.Sleep(ScriptMethods.randomize.Next(20500, 22000));

            //turn2
            ScriptMethods.SelectNode3_3_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
            ScriptMethods.SelectNode4_3_4N();
            Thread.Sleep(ScriptMethods.randomize.Next(1500, 2500));
        }
    }
}
