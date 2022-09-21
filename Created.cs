Banck banck = new Banck("ISP");
Console.WriteLine(banck.Name);



Utenti client = new Utenti("Gabriele", "Baglioni", "BGLGRL00T05H501F");

Console.WriteLine(client.ToString());




//Console.WriteLine("Inserisci il codice fiscale da cercare: ");
//List<Utenti> risultatoRicerca = banck.SearchUtente(Console.ReadLine());




Console.WriteLine("Inserisci il codice fiscale per vedere se c'e' un prestito collegato");
List<Loans> loanInput = banck.SearchLoan(Console.ReadLine());


