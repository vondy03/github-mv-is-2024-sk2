using System;
using System.Diagnostics;

class Program {
    static void Main() {

    string again = "a"; //opakování po stisku klávesky a
    while (again == "a"){
        Console.Clear();
        Console.WriteLine ("********************************");
        Console.WriteLine ("******** Součet a cifer ********");
        Console.WriteLine ("********************************");
        Console.WriteLine ("******* Matyáš Vondráček *******");
        Console.WriteLine ("********************************\n");
        Console.WriteLine ();

        Console.WriteLine("Zadejte celé číslo:");
        string number = Console.ReadLine();
        

        //Výpis uživatelského výstupu
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("Uživatel zadal: {0}", number);
        Console.WriteLine("=====================================");
    
        int suma = 0;
        
        foreach (char digitChar in number) //pomocí foreach cilku string number rozdělíme na jednotlivé znaky
        {
            int digit = digitChar - '0'; //využijeme toho, že čísla jsou představována v ASCII tabulce
            //například číslo 5 je 53, odečteme od něj tedy ASCII hodnotu "0", která je 48. Tato metoda funguje pro všechna jednociferná čísla.
            suma += digit; //přičteme číslo do celkové sumy.
        }

        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("Součet cifer čísla {0} je {1}", number, suma);
        Console.WriteLine("=====================================");

        //Opakování programu - TO DO
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}