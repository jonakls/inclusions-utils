
using System.Windows.Forms;
using InclusionsUtils.Manager;

namespace InclusionsUtils.Form
{
    public partial class AboutForm : System.Windows.Forms.Form
    {
        private readonly InclusionUtilityManager _manager;
        private readonly string _authorLink = "https://github.com/jonakls";
        private readonly string _projectLink = "https://github.com/jonakls/inclusions-utils";
        private readonly string _supportLink = "https://api.whatsapp.com/send?phone=3138494150&text=Hola%20jonathan,%20tengo%20un%20fallo%20con%20el%20programa%20de%20inclusiones";
        private readonly string _licenceLink = "https://github.com/jonakls/inclusions-utils/blob/master/LICENSE";
        
        public AboutForm(InclusionUtilityManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Dashboard(_manager).Show();
        }

        private void AuthorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(_authorLink);
        }

        private void ProjectLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(_projectLink);
        }


        private void SupportLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(_supportLink);
        }

        private void LicenceLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(_licenceLink);
        }
    }
}