using System.Windows.Forms;
using InclusionsUtils.Manager;

namespace InclusionsUtils.Utility
{
    public partial class FixPartsForm : Form
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
    }
}