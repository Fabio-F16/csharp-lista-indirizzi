using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        string Nome { get; set; }
        string Cognome { get; set; }
        string Via { get; set; }
        string Citta { get; set; }
        string Provincia { get; set; }
        string Cap { get; set; }

        public Indirizzo(string nome, string cognome, string via, string citta, string provincia, string cap)
        {
            Nome = nome;
            Cognome = cognome;
            Via = via;
            Citta = citta;
            Provincia = provincia;
            Cap = cap;
        }

        public string Stampa()
        {
            string stringa = "******indirizzo******\n";
            stringa += "Nome:\t" + this.Nome + "\n";
            stringa += "Cognome:\t" + this.Cognome + "\n";
            stringa += "Via:\t" + this.Via + "\n";
            stringa += "Città:\t" + this.Citta + "\n";
            stringa += "Provincia:\t" + this.Provincia + "\n";
            stringa += "Cap:\t" + this.Cap + "\n";

            return stringa;

        }
    }
}
