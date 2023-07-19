using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_studenti
{
    internal class ControlerCatalogStudenti : CatalogStudenti
    {
        private string numeStudenti;
        private string adresaLocuinta;
        private string materieParticipare;
        private string statusStudenti;

        private int nrAdresaLocuinta;
        private double noteStudent;
        private double mediaFinalaStudent;

        public ControlerCatalogStudenti(string numeStudenti, string adresaLocuinta, string materieParticipare, string statusStudenti, int nrAdresaLocuinta)
        {
            this.numeStudenti = numeStudenti;
            this.adresaLocuinta = adresaLocuinta;
            this.materieParticipare = materieParticipare;
            this.statusStudenti = statusStudenti;
            this.nrAdresaLocuinta = nrAdresaLocuinta;
            
        }

        public double NoteStudent { get => noteStudent; set => noteStudent = value; }   
        public double MediaFinalaStudent { get => mediaFinalaStudent; set => mediaFinalaStudent = value; }
    }
}
