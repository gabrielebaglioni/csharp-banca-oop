using System;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class Utenti
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public double Salary { get; private set; }
    public string CF { get; set; }
    public bool isRegistred { get; set; }


    public Utenti(string name, string surname, string cf)
    {
        Name = name;
        Surname = surname;
        Salary = new Random().Next(1000, 10000);
        CF = cf;
    }
   

    public override string ToString()
    {
        return $"{Name} {Surname} {Salary} {CF} ";
    }
}



