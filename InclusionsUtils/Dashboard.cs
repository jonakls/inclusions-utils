using InclusionsUtils.Manager;
using System;
using System.Windows.Forms;
using InclusionsUtils.Form;

namespace InclusionsUtils
{
    public partial class Dashboard : System.Windows.Forms.Form
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
            /*
            * en InclusionsUtils.Form.FixPartsForm.InitializeComponent() en D:\Programación\RiderProjects\inclusions-utils\InclusionsUtils\Form\FixPartsForm.Designer.cs:línea 159
            * en InclusionsUtils.Form.FixPartsForm..ctor(InclusionUtilityManager manager) en D:\Programación\RiderProjects\inclusions-utils\InclusionsUtils\Form\FixPartsForm.cs:línea 15
            * en InclusionsUtils.Dashboard.fixParts_Click(Object sender, EventArgs e) en D:\Programación\RiderProjects\inclusions-utils\InclusionsUtils\Dashboard.cs:línea 38
            */
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Pre cerrado de este form
            Application.Exit();
        }

        private void resolveButton_Click(object sender, EventArgs e)
        {
            FixResolvesForm fixResolvesForm = new FixResolvesForm(_manager);
            fixResolvesForm.Show();
            Hide();
        }

        private void aboutMe_Click(object sender, EventArgs e)
        {
            new AboutForm(_manager).Show();
            Hide();
        }
    }
}
