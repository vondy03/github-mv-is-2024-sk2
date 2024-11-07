using System;
using System.Diagnostics;

class Program {
    static void Main() {

    string again = "a"; //opakování po stisku klávesky a
    while (again == "a"){
        Console.Clear();
        Console.WriteLine ("***********************************");
        Console.WriteLine ("********** Analýza textu **********");
        Console.WriteLine ("***********************************");
        Console.WriteLine ("******** Matyáš Vondráček *********");
        Console.WriteLine ("***********************************\n");
        Console.WriteLine ();

        Console.WriteLine ("\nZadejte text pro anylýzu: ");
        string myText = Console.ReadLine();
        Console.WriteLine ();
        Console.WriteLine (myText);
        Console.WriteLine (myText.Length);

        string samohlasky = "aáeéiíoóuúůyý";
        string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
        string cislice = "0123456789";

        int pocetSamohlasek = 0;
        int pocetSouhlasek = 0;
        int pocetCisel = 0;
        int pocetOstatnich = 0;

       foreach (char znak in myText){
            if(souhlasky.Contains(znak)){
                pocetSouhlasek++;
            }
            else if(samohlasky.Contains(znak)){
                pocetSamohlasek++;
            }
            else if(cislice.Contains(znak)){
                pocetCisel++;
            }
            else {
                pocetOstatnich++;
            }

       }

       Console.WriteLine("\n\nPočet samohlásek: {0}", pocetSamohlasek);
       Console.WriteLine("Počet souhlasek: {0}", pocetSouhlasek);
       Console.WriteLine("Počet čísel: {0}", pocetCisel);
       Console.WriteLine("Počet ostatních zanků: {0}", pocetOstatnich);

        
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}