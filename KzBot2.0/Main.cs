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
            NoxName = textBox1.Text;
            if (!NoxOpened())
            {
                MessageBox.Show("Could not find Nox Player", "Nox Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GetRuns();
            SelectedMap = "4-3E";
            FormProvider.RunManagerForm.Text = "Running " + SelectedMap;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoxName = textBox1.Text;
            if (!NoxOpened())
            {
                MessageBox.Show("Could not find Nox Player", "Nox Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GetRuns();
            SelectedMap = "0-2";
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
            ScriptMethods.TakeFormationScreenShotDefault();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScriptMethods.TakeRepairScreenShotDefault();
        }
    }
}
