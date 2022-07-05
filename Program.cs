namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello, World!");

            StreamReader indirizzi = File.OpenText("C:\\Users\\Fabioz\\Desktop\\Net\\csharp-lista-indirizzi\\addresses.csv");

            string intestazione = indirizzi.ReadLine();
            //Console.WriteLine(intestazione);

            List<Indirizzo> listaIndirizzi = new List<Indirizzo>();
            List<string> listaIndirizziSbagliati = new List<string>();


            while (!indirizzi.EndOfStream)
            {
                string linea = indirizzi.ReadLine();
                //Console.WriteLine(linea);
                string[] data = linea.Split(",");         
                //for(int i = 0; i < data.Length; i++)
                //{
                //    Console.Write(data[i]);
                //}
                try
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        //Console.Write(data[i]);
                        if (data[i] == "")
                        {
                            data[i] = "null";
                        }


                    }
                    string nome = data[0];
                    string cognome = data[1];
                    string via = data[2];
                    string città = data[3];
                    string provincia = data[4];
                    string cap = data[5];

                    Indirizzo indirizzo = new Indirizzo(nome, cognome, via, città, provincia, cap);
                    listaIndirizzi.Add(indirizzo);              
                }
                catch (IndexOutOfRangeException e)
                {
                   // listaIndirizziSbagliati.Add(linea);
                   Console.WriteLine(e.Message);
                }

            }
            foreach (Indirizzo indirizzoz in listaIndirizzi)
            {
                Console.Write("Nome: " + indirizzoz.Nome + " // ");
                Console.Write("Cognome: " + indirizzoz.Cognome + " // ");
                Console.Write("Via: " + indirizzoz.Via + " // ");
                Console.Write("Città: " + indirizzoz.Citta + " // ");
                Console.Write("Provincia: " + indirizzoz.Provincia + " // ");
                Console.Write("Cap: " + indirizzoz.Cap + " // ");
                Console.WriteLine("\n*************************************");
                Console.WriteLine();
            }
            indirizzi.Close();
        }
    }
}