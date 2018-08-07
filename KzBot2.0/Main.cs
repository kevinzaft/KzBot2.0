using System;
using System.Windows.Forms;


namespace KzBot2
{
    public partial class Main : Form
    {
        public String SelectedMap = "";
        public String NoxName = "";
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProvider.InputForm = new InputForm();
            NoxName = textBox1.Text;
            if (!NoxOpened())
            {
                MessageBox.Show("Could not find Nox Player", "Nox Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedMap = "4-3E";
            GetRuns();
            FormProvider.RunManagerForm.Text = "Running " + SelectedMap;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProvider.InputForm = new InputForm();
            NoxName = textBox1.Text;
            if (!NoxOpened())
            {
                MessageBox.Show("Could not find Nox Player", "Nox Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedMap = "0-2";
            GetRuns();
            FormProvider.RunManagerForm.Text = "Running " + SelectedMap;
        }

        private void GetRuns()
        {
            FormProvider.InputForm.Show();
            this.Hide();
        }

        private Boolean NoxOpened()
        {
            return ((int)Helper.FindNox() != 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoxName = textBox1.Text;
            ScriptMethods.TakeFormationScreenShotDefault();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NoxName = textBox1.Text;
            ScriptMethods.TakeRepairScreenShotDefault();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormProvider.InputForm = new InputForm();
            NoxName = textBox1.Text;
            if (!NoxOpened())
            {
                MessageBox.Show("Could not find Nox Player", "Nox Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedMap = "LogiScript";
            GetRuns();
            FormProvider.RunManagerForm.Text = "Running " + SelectedMap;
        }
    }
}
