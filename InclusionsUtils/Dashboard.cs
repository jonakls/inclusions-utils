using InclusionsUtils.Manager;
using InclusionsUtils.Utility;
using System;
using System.Windows.Forms;

namespace InclusionsUtils
{
    public partial class Dashboard : Form
    {
        
        private InclusionUtilityManager manager;

        public Dashboard(InclusionUtilityManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Radicados general
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Conversor de partes
            PartConverterForm converterForm = new PartConverterForm(manager);
            converterForm.Show();
            this.Hide();
        }

        private void fixParts_Click(object sender, EventArgs e)
        {
            // Arreglar partes
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Pre cerrado de este form
            Application.Exit();
        }
    }
}
