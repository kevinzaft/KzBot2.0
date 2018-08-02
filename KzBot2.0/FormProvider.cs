using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KzBot2
{
    class FormProvider
    {

        public static Main MainForm { get; set; } = new Main();
        public static InputForm InputForm { get; set; } = new InputForm();
        public static RunManagerForm RunManagerForm { get; set; } = new RunManagerForm();

        public static ArrayList ThreadList { get; set; } = new ArrayList();

        public static void Reset()
        {
            MainForm = new Main();
            InputForm = new InputForm();
            RunManagerForm = new RunManagerForm();
        }
    }
}
