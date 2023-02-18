using FisheriesAgency.View;

namespace FisheriesAgency
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //TODO: close frmLogin (when you close frmLogin everything will close)
            //this.Dispose();      //this is the code for closing the login form
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
        }
    }
}