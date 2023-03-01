using System;
using System.Windows.Forms;
using InclusionsUtils.Manager;
using InclusionsUtils.Utils;

namespace InclusionsUtils.Form
{
    public partial class FixPartsForm : System.Windows.Forms.Form
    {

        private readonly InclusionUtilityManager _manager;
        
        public FixPartsForm(InclusionUtilityManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void FixPartsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard(_manager);
            dashboard.Show();
        }

        private void fixPartsButton_Click(object sender, EventArgs e)
        {
            resultParts.Text = TextUtils.ConvertText(damageParts.Text);
        }

        private void copyResultButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultParts.Text);
        }
    }
}