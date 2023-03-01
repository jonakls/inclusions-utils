using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InclusionsUtils.Manager;

namespace InclusionsUtils.Form
{
    public partial class PartConverterForm : System.Windows.Forms.Form
    {
        private readonly InclusionUtilityManager _manager;
        
        public PartConverterForm(InclusionUtilityManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void PartConverterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void PartConverterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard(_manager);
            dashboard.Show();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> result = _manager.ConvertParts(oldParts.Text, pagesList.Text);
            if (result == null)
            {
                defandants.Text = @"NO SE PUDO CONVERTIR EL TEXTO CONTACTA CON EL DESARROLLADOR";
                complainants.Text = @"NO SE PUDO CONVERTIR EL TEXTO CONTACTA CON EL DESARROLLADOR";
                return;
            }

            defandants.Text = result["DEMANDADO"];
            complainants.Text = result["DEMANDANTE"];
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            oldParts.Text = null;
            defandants.Text = null;
            complainants.Text = null;
        }

        private void copyDefandants_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(defandants.Text);
        }

        private void copyComplainants_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(complainants.Text);
        }
    }
}
