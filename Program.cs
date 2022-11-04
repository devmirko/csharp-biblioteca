// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

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







public class Biblioteca
{
    public List<Documenti> documenti;
    public List<Utente> utenti;

    public Biblioteca()
    {
        string[] nomi = { "pippo", "mario", "giacomo", "lorenzo", "mauro", "francesco" };
        string[] cognomi = { "elso", "Viola", "vico", "Balzo", "sassi", "falla"};
        documenti = new List<Documenti>();
        utenti = new List<Utente>();

        //libri
        Libri libro1 = new Libri("sjsjsjsjs", "pulcinella", new Random().Next(0, 3000), "avventura", true, "12b", "gianni verroni", new Random().Next(0, 100));
        Libri libro2 = new Libri("bdffg", "arlecchino", new Random().Next(0, 3000), "avventura", true, "10b", "gianni buzzo", new Random().Next(0, 100));
        Libri libro3 = new Libri("lmnopq", "superman", new Random().Next(0, 3000), "fantascienza", true, "8a", "gianni buzzo", new Random().Next(0, 100));

        //Dvd
        Dvd dvd1 = new Dvd("123456", "spiderman", new Random().Next(0, 3000), "fantascienza", true, "12b", "dominik alk", new Random().Next(0, 100));
        Dvd dvd2 = new Dvd("134567", "hulk", new Random().Next(0, 3000), "fantascienza", true, "12b", "dominik alk", new Random().Next(0, 100));
        Dvd dvd3 = new Dvd("789123", "ironman", new Random().Next(0, 3000), "fantascienza", true, "12b", "dominik alk", new Random().Next(0, 100));

        documenti.Add(libro1);
        documenti.Add(libro2);
        documenti.Add(libro3);
        documenti.Add(dvd1);
        documenti.Add(dvd2);
        documenti.Add(dvd3);

        for (int i = 0; i < 6; i++)
        {
            utenti.Add(new Utente(nomi[i], cognomi[i]));
        }

    }

    public string Ricerca(string cod)
    {
        foreach(Documenti documento in documenti)
        {
            if (documento.Codice == cod || documento.Titolo == cod)
            {
                return documento.ToString();
            }
        }
        return "non sono stati trovati documenti";

    }

    }










public class Documenti
{
    public string Codice { get; set; }

    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool Stato { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; set; }

    //costruttore
    public Documenti(string codice, string titolo, int anno, string settore, bool stato, string scaffale, string autore)
    {
        Codice = codice;
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

    public Libri(string codice, string titolo, int anno, string settore, bool stato, string scaffale, string autore, int numeroPagine) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        NumeroPagine = numeroPagine;
        

    }

    public override string ToString()
    {
        return "ISBN = " + Codice + "-  Titolo: " + Titolo;
    }

}


public class Dvd : Documenti
{
    public int Durata { get; set; }

    public Dvd(string codice, string titolo, int anno, string settore, bool stato, string scaffale, string autore, int durata) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        Durata = durata;





    }
    public override string ToString()
    {
        return "Serial = " + Codice + "-  Titolo: " + Titolo;
    }

}

public class Utente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public int Telefono { get; set; }

    public Utente(string nome, string cognome)
    {
        Nome = nome;
        Cognome = cognome;
    }


}
