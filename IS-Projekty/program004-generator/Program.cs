using System;
using System.Diagnostics;

class Program {
    static void Main() {

    string again = "a"; //opakování po stisku klávesky a
    while (again == "a"){
        Console.Clear();
        Console.WriteLine ("*****************************************************");
        Console.WriteLine ("********** Generátor pseudonáhodných čísel **********");
        Console.WriteLine ("*****************************************************");
        Console.WriteLine ("***************** Matyáš Vondráček ******************");
        Console.WriteLine ("*****************************************************\n");
        Console.WriteLine ();


        //Vstup od uživatele -správná varianta
        Console.WriteLine("Zadejte počet generovaných čísel (celé číslo):");
        int n;
        while (!int.TryParse(Console.ReadLine(),out n)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu počet generovaných čísel (celé číslo):");
        }

        Console.WriteLine("Zadejte dolní mez (celé číslo):");
        int dm;
        while (!int.TryParse(Console.ReadLine(),out dm)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu Zadejte dolní mez (celé číslo):");
        }

        Console.WriteLine("Zadejte horní mez (celé číslo):");
        int hm;
        while (!int.TryParse(Console.ReadLine(),out hm)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu Zadejte horní mez (celé číslo):");
        }

        //deklarace pole
        int[] myArray = new int[n];

        // příprava pro generování náhodných čísel
        Random randomNumber = new Random();

        Console.WriteLine("Náhodná čísla: ");
        for (int i = 0; i < n; i++)
        {
        myArray[i] = randomNumber.Next(dm, hm+1);
        Console.Write("{0}; ", myArray[i]);
        }


        //Výpis uživatelského vstupu
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("Uživatelský vstup:");
        Console.WriteLine("Počet čísel: {0}; dolní mez {1}; horní mez {2}", n, dm ,hm);
        Console.WriteLine("=====================================\n\n");

        //Opakování programu - TO DO
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}