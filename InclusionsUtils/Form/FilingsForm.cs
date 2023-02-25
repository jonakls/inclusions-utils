using System.Windows.Forms;
using InclusionsUtils.Manager;

namespace InclusionsUtils.Form
{
    public partial class FilingsForm : System.Windows.Forms.Form
    {
        private readonly InclusionUtilityManager _manager;
        
        public FilingsForm(InclusionUtilityManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void FilingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard(_manager);
            dashboard.Show();
        }
    }
}