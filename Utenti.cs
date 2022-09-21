using System;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class Utenti
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Salary { get;  set; }
    public string CF { get; set; }
    public bool isRegistred { get; set; }
    public List<Loans> Loan { get; }


    public Utenti(string name, string surname, string cf)
    {
        Name = name;
        Surname = surname;
        Salary = GetSalary();
        CF = cf;
        Loan = new List<Loans>();
    }

    public void SetSalary(int salary)
    {
        this.Salary = new Random().Next(1000, 10000); ;
    }
    public int GetSalary()
    {
        return Salary;
    }
    public override string ToString()
    {
        return $"{Name} {Surname} {Salary} {CF} ";
    }
}



