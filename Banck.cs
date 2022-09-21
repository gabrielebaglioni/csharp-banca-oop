public class Banck
{
    public string Name { get; set; }

    List<Utenti> utenti;

    List<Loans> loans;

    public Banck(string name)
    {
        Name = name;
        Utenti client = new Utenti("Gabriele", "Baglioni", "BGLGRL00T05H501F");
        this.utenti = new List<Utenti> { client };
        loans = new List<Loans>();
    }
    public List<Utenti> SearchUtente(string CF)
    {
        List<Utenti> risultatoRicerca = new List<Utenti>();
        //ritorna lista di clienti con quel nome e cognome
        foreach (Utenti utente in utenti)
        {
            if (utente.CF.ToLower()  == utente.CF.ToLower())
            {
                risultatoRicerca.Add(utente);
                Console.WriteLine(utente.ToString());

            }
            else
            {
                Console.WriteLine("NON à presente");
            }
        }
        return risultatoRicerca;
    }
}