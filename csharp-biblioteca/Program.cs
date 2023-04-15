using System.Runtime.ConstrainedExecution;

namespace csharp_biblioteca
{
    internal class Program
    {

        //Si vuole progettare un sistema per la gestione di una biblioteca.
        //Gli utenti si possono registrare al sistema, fornendo:
        //cognome
        //nome
        //email
        //password
        //recapito telefonico
        class utente
        {
            string cognome;
            string nome;
            string email;
            string password;
            string telefono;

            //costruttore
         public utente(
            string cognome,
            string nome,
            string email,
            string password,
            string telefono
             )
            {
                this.cognome = cognome;
                this.nome = nome;
                this.email = email;
                this.password = password;
                this.telefono = telefono;
            }
        }




        //Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
        //I documenti sono caratterizzati da:
        //un codice identificativo di tipo stringa
        //titolo
        //anno
        //settore (storia, matematica, economia, …)
        //uno scaffale in cui è posizionato
        //un autore (Nome, Cognome)

        class documento
        {
            public string codice;
            public string titolo;
            public int anno;
            public string settore;
            public string scaffale;
            public string autore;

            //costruttore
            public documento(string titolo, int anno, string settore, string scaffale, string autore)
            {
                Random rnd = new Random();
                this.codice = rnd.Next(1, 999999).ToString();
                this.titolo = titolo;
                this.anno = anno;
                this.settore = settore;
                this.scaffale = scaffale;
                this.autore = autore;
            }
        }



        //Per i libri si ha in aggiunta il numero di pagine,
        class libro : documento
        {
            int pagine;

            //costruttore
            public libro(string titolo, int anno, string settore, string scaffale, string autore, int pagine) : 
                base ( titolo,  anno,  settore,  scaffale,  autore)
            { 

                this.pagine = pagine;
            }
        }

        //mentre per i dvd la durata.
        class dvd : documento
        {
            public int durata;


            //costruttore
            public dvd(string titolo, int anno, string settore, string scaffale, string autore, int durata) :
                base(titolo, anno, settore, scaffale, autore)
            {

                this.durata = durata;
            }
        }

        static void Main(string[] args)
        {


        }
    }
}
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente,
//prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
//Creiamo anche una classe Biblioteca che contiene la lista dei documenti,
//la lista degli utenti e la lista dei prestiti.
//Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.