// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");

/*i vuole progettare un sistema per la gestione di una biblioteca.*/
//Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//password,
//recapito telefonico,

//Gli utenti  possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:

//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).

//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

Console.WriteLine("benvenuti nella biblioteca");
Console.WriteLine("cerca il tuo libro");

public class Documenti
{
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool Stato { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; set; }

    //costruttore
    public Documenti(string titolo, int anno, string settore, bool stato, string scaffale, string autore)
    {
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Stato = stato;
        Scaffale = scaffale;
        Autore = autore;






    }
}


public class Libri : Documenti
{
    public int NumeroPagine { get; set; }

    public Libri(string titolo, int anno, string settore, bool stato, string scaffale, string autore, int numeroPagine) : base(titolo, anno, settore, stato, scaffale, autore)
    {
        NumeroPagine = numeroPagine;

    }

}


public class Dvd : Documenti
{
    public int Durata { get; set; }

    public Dvd(string titolo, int anno, string settore, bool stato, string scaffale, string autore, int durata) : base(titolo, anno, settore, stato, scaffale, autore)
    {
        Durata = durata;


    }

}
