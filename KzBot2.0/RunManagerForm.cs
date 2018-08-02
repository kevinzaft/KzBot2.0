using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KzBot2
{
    public partial class RunManagerForm : Form
    {
        public RunManagerForm()
        {
            InitializeComponent();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread fThread = (Thread)FormProvider.ThreadList[FormProvider.ThreadList.Count - 1];
            fThread.Abort();
            FormProvider.ThreadList.Remove(fThread);
            this.Hide();
            FormProvider.MainForm.Show();
        }
    }
}
