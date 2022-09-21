public class Banck
{
    public string Name { get; set; }
   
    List<Utenti> utenti;

    List<Loans> loans;

    public Banck(string name)
    {
        Name = name;
        utenti = new List<Utenti>();
        loans = new List<Loans>();
    }
}