using InclusionsUtils.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InclusionsUtils.Utility
{
    public partial class PartConverterForm : Form
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
            Dictionary<string, string> result = _manager.ConvertParts(oldParts.Text);
            if (result == null)
            {
                defandants.Text = "NO SE PUDO CONVERTIR EL TEXTO CONTACTA CON EL DESARROLLADOR";
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
