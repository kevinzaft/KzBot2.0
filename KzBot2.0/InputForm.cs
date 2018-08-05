using System;
using System.Threading;
using System.Windows.Forms;

namespace KzBot2
{
    public partial class InputForm : Form
    {
        public int runs = 0;
        public string draggerType = "";
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e) { comboBox1.SelectedIndex = 0; }
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
            draggerType = (string)comboBox1.SelectedItem;
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
                    E4_3.StartRun(runs, draggerType);
                }
                else
                {
                    N0_2.StartRun(runs, draggerType);
                }
                runs--;
                FormProvider.MainForm.Invoke(new MethodInvoker(() =>
                {
                    FormProvider.RunManagerForm.label2.Text = "Runs left: " + runs;
                }));
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
