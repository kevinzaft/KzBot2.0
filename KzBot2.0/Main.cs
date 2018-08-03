using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Drawing.Imaging;

namespace KzBot2
{
    public partial class Main : Form
    {
        public String SelectedMap = "";
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            return ((int)Helper.FindWindow("Qt5QWindowIcon", null) != 0);
        }
    }
}
