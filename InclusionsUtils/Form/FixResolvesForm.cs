using System;
using System.Windows.Forms;
using InclusionsUtils.Manager;
using InclusionsUtils.Utils;

namespace InclusionsUtils.Form
{
    public partial class FixResolvesForm : System.Windows.Forms.Form
    {
        private readonly InclusionUtilityManager _manager;
        
        public FixResolvesForm(InclusionUtilityManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void fixResolve_Click(object sender, EventArgs e)
        {
            // Arreglar partes
            string result = TextUtils.ResolveText(TextUtils.ConvertText(damageResolve.Text));
            resultResolve.Text = result;
            
        }

        private void copyResultButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultResolve.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            damageResolve.Text = "";
            resultResolve.Text = "";
        }

        private void FixResolvesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard(_manager);
            dashboard.Show();
        }
    }
}