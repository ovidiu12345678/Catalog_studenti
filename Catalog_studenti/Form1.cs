using System.DirectoryServices;

namespace Catalog_studenti
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             CatalogStudenti catalogStudenti = new CatalogStudenti();

                if(DialogResult == DialogResult.OK && catalogStudenti.Username == textUser.Text && catalogStudenti.Passowrd == textPassword.Text )
                {
                  catalogStudenti.Show();
                }
                else
                {
                  MessageBox.Show("Nu ati introdus parola /  Parola gresita sau Username gresit ! Incercati din nou ! ");
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}