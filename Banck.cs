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

    //Add

    public void AddUtente(Utenti utente)
    {
        utenti.Add(utente);
        utente.isRegistred = true;
    }
    //remove
    public void RemoveUtente(Utenti utente)
    {
        utenti.Remove(utente);
        utente.isRegistred = false;
    }

    //SEARCH
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
    //edit
    public void editUtente(Utenti user, int newSalary)
    {
        if (utenti.Contains(user))
        {
            user.Salary = newSalary;
        }
        else
        {
            throw new Exception("User not found");
        }
    }
    //prestito
    public void addUtenteLoan(Loans loan, Utenti utente)
    {
        loans.Add(loan);
        utente.Loan.Add(loan);
    }
}