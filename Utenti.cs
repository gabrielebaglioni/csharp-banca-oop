public class Utenti
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public double Salary { get; set; }
    public string CF { get; set; }
    public bool isRegistred { get; set; }


    public Utenti(string name, string surname, double salary,  string cf)
    {
        Name = name;
        Surname = surname;
        Salary = salary;
        CF = cf;
    }
}