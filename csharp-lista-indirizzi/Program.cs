// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;
List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

try
{
    StreamReader file = File.OpenText("C:\\Users\\minec\\Desktop\\Visual Studio 2022 Esercizi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\addresses.csv");
    int contatoreRigheLette = 0;
    while (!file.EndOfStream)
    {

        string rigaDiTestoLetta = file.ReadLine();
        contatoreRigheLette++;

        if (contatoreRigheLette > 1)
        {
            string[] informazioniSeparate = rigaDiTestoLetta.Split(',');

            if (informazioniSeparate.Length != 6)
            {
                Console.WriteLine("La riga " + contatoreRigheLette + "non rispetta lo standard richiesto di 5 informazioni per riga");
            }
            else
            {

                //int zip = int.Parse(informazioniSeparate[5]);

                try
                {
                    Indirizzo indirizzoLetto = new Indirizzo(informazioniSeparate[0], informazioniSeparate[1], informazioniSeparate[2], informazioniSeparate[3], informazioniSeparate[4], informazioniSeparate[5]);
                    listaIndirizzi.Add(indirizzoLetto);
                }
                catch (Exception e)
                {
                    Console.WriteLine("C'è stato un errore nella lettura dell'indirizzo in riga n° " + contatoreRigheLette);
                    Console.WriteLine("L'errore è: " + e.Message);
                }
            }
        }
    }

}
catch (Exception ex)
{
    Console.WriteLine("Qualcosa è andato storto...");
    Console.WriteLine(ex.Message);
}



// Stampa indirizzo dalla lista
foreach (Indirizzo indirizzo in listaIndirizzi)
{
    Console.WriteLine(indirizzo);
}
