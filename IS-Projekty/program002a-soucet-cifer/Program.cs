using System;
using System.Diagnostics;

class Program {
    static void Main() {

    string again = "a"; //opakování po stisku klávesky a
    while (again == "a"){
        Console.Clear();
        Console.WriteLine ("********************************");
        Console.WriteLine ("**** Součet a součin cifer *****");
        Console.WriteLine ("********************************");
        Console.WriteLine ("******* Matyáš Vondráček *******");
        Console.WriteLine ("********************************\n");
        Console.WriteLine ();

        //Vstup od uživatele -správná varianta
        Console.WriteLine("Zadejte celé číslo:");
        int number;
        while (!int.TryParse(Console.ReadLine(),out number)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
        }

        //Výpis uživatelského výstupu
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("Uživatel zadal: {0}", number);
        Console.WriteLine("=====================================/n/n");
    
        int suma = 0;
        int numberBackup = number;
        int digit;

        if (number < 0) {
            number = - number;
        }

        while (number >= 10) {
            digit =  number % 10; // % > operátor modulo zbytek po celočíselném dělení
            number = (number - digit) / 10;
            Console.WriteLine("Digit = {0}", digit);
            suma = suma + digit;
        }
        Console.WriteLine("Digit = {0}", number);
        suma = suma + number;


        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
        Console.WriteLine("=====================================");

        //Opakování programu - TO DO
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}