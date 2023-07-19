using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Catalog_studenti
{
    public partial class CatalogStudenti : Form 
    {
        private string textUsername = "Admin.2023";
        private string textPassword = "Catalog.2023";

       
        public CatalogStudenti()
        {
            InitializeComponent();
        }

        public string Passowrd { get => textPassword; set => textPassword = value; }
        public string Username { get => textUsername; set => textUsername = value; }

        string numeStudenti, adresaLocuinta, materieParticipare, statusStudenti;

        int nrAdresaLocuinta;
         

         
        
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ControlerCatalogStudenti  controlerCatalogStudenti1 = new ControlerCatalogStudenti(numeStudenti, adresaLocuinta, materieParticipare, statusStudenti, nrAdresaLocuinta);

            if (controlerCatalogStudenti1.Enabled == true)
            {
                this.numeStudenti = textBox1.Text;
                this.adresaLocuinta = textBox2.Text;
                this.nrAdresaLocuinta = int.Parse(textBox3.Text.ToString());
                this.statusStudenti = textBox7.Text;
                this.materieParticipare =  textBox4.Text;

                ListViewItem listViewItem = listCatalog2023.Items.Add( controlerCatalogStudenti1.numeStudenti.ToString());

                listViewItem.SubItems.Add(adresaLocuinta.ToString());
                listViewItem.SubItems.Add(materieParticipare.ToString());
                listViewItem.SubItems.Add(statusStudenti.ToString());
                listViewItem.SubItems.Add(nrAdresaLocuinta.ToString());

                ControlerCatalogStudenti controlerCatalogStudenti = new ControlerCatalogStudenti(numeStudenti, adresaLocuinta, materieParticipare, statusStudenti, nrAdresaLocuinta);
                listViewItem.SubItems.Add(controlerCatalogStudenti.NoteStudent.ToString());
                listViewItem.SubItems.Add(controlerCatalogStudenti.MediaFinalaStudent.ToString());

                controlerCatalogStudenti.NoteStudent = double.Parse(textBox5.Text.ToString());
                controlerCatalogStudenti.MediaFinalaStudent = double.Parse(textBox6.Text.ToString());

            }
          
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
