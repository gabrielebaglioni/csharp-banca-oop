Banck banck = new Banck("ISP");
Console.WriteLine(banck.Name);



Utenti Gabriele = new Utenti("Gabriele", "Baglioni", "BGLGRL00T05H501F");
banck.AddUtente(Gabriele);

Console.WriteLine(Gabriele.ToString());



Loans loan1 = new Loans(1, Gabriele, 200, 20);
banck.addUtenteLoan( loan1, Gabriele);




//Console.WriteLine("Inserisci il codice fiscale da cercare: ");
//List<Utenti> risultatoRicerca = banck.SearchUtente(Console.ReadLine());




Console.WriteLine("Inserisci il codice fiscale per vedere se c'e' un prestito collegato");
List<Loans> loanInput = banck.SearchLoan(Console.ReadLine());


