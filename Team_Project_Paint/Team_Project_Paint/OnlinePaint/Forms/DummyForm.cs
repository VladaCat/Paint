
using System.Windows.Forms;

namespace Team_Project_Paint
{
    public partial class DummyForm : Form
    {
        public DummyForm()
        {
            InitializeComponent();
        }

        private void DummyForm_Load(object sender, System.EventArgs e)
        {
            FormsManager.autorizationForm = new AutorizationForm();
            FormsManager.registrationForm = new RegistartionForm();
            FormsManager.mainForm = new MainForm();
            FormsManager.statsForm = new StatsForm();
            FormsManager.remoteLoadForm = new RemoteLoadForm();
            FormsManager.remoteSaveForm = new RemoteSaveForm();

            FormsManager.autorizationForm.Show();

        }

        private void DummyForm_Shown(object sender, System.EventArgs e)
        {
            Hide();
        }
    }
}
