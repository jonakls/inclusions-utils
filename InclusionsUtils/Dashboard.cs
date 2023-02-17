using InclusionsUtils.Manager;
using InclusionsUtils.Utility;
using System;
using System.Windows.Forms;

namespace InclusionsUtils
{
    public partial class Dashboard : Form
    {
        
        private readonly InclusionUtilityManager _manager;

        public Dashboard(InclusionUtilityManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Radicados general
            FilingsForm filingsForm = new FilingsForm(_manager);
            filingsForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Conversor de partes
            PartConverterForm converterForm = new PartConverterForm(_manager);
            converterForm.Show();
            Hide();
        }

        private void fixParts_Click(object sender, EventArgs e)
        {
            // Arreglar partes
            FixPartsForm fixPartsForm = new FixPartsForm(_manager);
            fixPartsForm.Show();
            Hide();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Pre cerrado de este form
            Application.Exit();
        }
    }
}
