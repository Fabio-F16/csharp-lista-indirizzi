using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Via { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string Cap { get; set; }

        public Indirizzo(string nome, string cognome, string via, string citta, string provincia, string cap)
        {
            Nome = nome;
            Cognome = cognome;
            Via = via;
            Citta = citta;
            Provincia = provincia;
            Cap = cap;
        }

    }
}
