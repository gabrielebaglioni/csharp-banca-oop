public class Loans
{
    

    public int Id { set; get; }
    public Utenti LoanUtente { get; }
    public int Ammontare { set; get; }
    public int Rata { set; get; }
    public DateOnly StartDate { get; }
    public DateOnly EndDate { get; private set; }
    


public Loans(int id, Utenti loanUtente, int ammontare, int rata)
    {
        Id = id;
        LoanUtente = loanUtente;
        Ammontare = ammontare;
        Rata = rata;
        StartDate = new DateOnly(2022, 1, 1);
        EndDate = StartDate.AddMonths((int)(Ammontare / rata) + 1);
        
    }


}