using GestioneLibro;
using GestioneMacchina;
using GestioneUtente;

class Program
{
    static void Main(string[] args)
    {
        int scelta;

        do
        {
            Console.WriteLine($"Ciao, Che esercizio vuoi vedere ?");
            Console.WriteLine($"1: Libro");
            Console.WriteLine($"2: Macchina");


            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    EssLibro();
                    break;

                case 2:
                    EssMacchina();
                    break;

                case 0:
                    Console.WriteLine($"Esco dal programma...");
                    break;

                default:
                    Console.WriteLine($"scelta non valida");
                    break;
            }


        } while (scelta != 0);

    }

    public static void EssLibro()
    {
        Libro l1 = new Libro("The Lord Of The Rings: The Fellowship Of The Ring", "Tolkien", 1954);
        Libro l2 = new Libro("The Lord Of The Rings: The Fellowship Of The Ring", "Tolkien", 1954);

        Console.WriteLine($"ToString:");
        Console.WriteLine(l1.ToString());
        Console.WriteLine(l2.ToString());
        Console.WriteLine();

        Console.WriteLine($"Equals:");
        Console.WriteLine($"l1 == l2 ? {l1.Equals(l2)}");
        Console.WriteLine();

        Console.WriteLine("Test GetHashCode:");
        Console.WriteLine($"Hash l1: {l1.GetHashCode()}");
        Console.WriteLine($"Hash l2: {l2.GetHashCode()}");
    }

    public static void EssMacchina()
    {
        List<Macchina> macchine = new List<Macchina>();
        List<Utente> utenti = new List<Utente>();

        Console.WriteLine($"Benvenuto da Los Santos Customs, Inserisci i tuoi dati per iniziare la modifica");
        Console.WriteLine();

        Console.Write("Inserisci il tuo nome: ");
        string nome = Console.ReadLine();

        Console.Write("Inserisci il tuo Cognome: ");
        string cognome = Console.ReadLine();

        Console.Write("crediti iniziale: 5");
        int crediti = 5;

        Utente utente = new Utente(nome, cognome, crediti);
        utenti.Add(utente);

        Macchina macchina = new Macchina("V5 1000c", 120.57f, 500, 0);
        macchine.Add(macchina);

        Macchina.GestisciModifiche(utente, macchina);

    }

}