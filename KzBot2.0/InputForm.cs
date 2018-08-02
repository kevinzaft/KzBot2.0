using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KzBot2
{
    public partial class InputForm : Form
    {
        public int runs = 0;
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e) { }
        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            numericUpDown1.Value = 0;
            FormProvider.MainForm.Show();
            e.Cancel = true;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            runs = Int32.Parse(numericUpDown1.Text);
            this.Hide();
            numericUpDown1.Value = 0;
            FormProvider.RunManagerForm.label2.Text = "Runs left: " + runs;
            FormProvider.RunManagerForm.Show();
            Thread fThread = new Thread(() => ScriptThread(FormProvider.MainForm.SelectedMap));
            fThread.Start();
            FormProvider.ThreadList.Add(fThread);
        }

        private void ScriptThread(String map)
        {
            while (runs > 0)
            {
                if (map.Equals("4-3E"))
                {

                }
                else
                {

                }
                //Debug.Print(runs--.ToString());
                //Thread.Sleep(1000);
            }


            FormProvider.MainForm.Invoke(new MethodInvoker(() => 
            {
                FormProvider.RunManagerForm.Hide();
                FormProvider.MainForm.Show();
                FormProvider.ThreadList.Remove(Thread.CurrentThread);
            } ));
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            numericUpDown1.Value = 0;
            FormProvider.MainForm.Show();
        }
    }
}
