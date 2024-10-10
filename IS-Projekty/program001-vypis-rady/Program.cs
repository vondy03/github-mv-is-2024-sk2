using System;
using System.Diagnostics;

class Program {
    static void Main() {

    string again = "a"; //opakování po stisku klávesky a
    while (again == "a"){
        Console.Clear();
        Console.WriteLine ("********************************");
        Console.WriteLine ("********** Výpis Řady **********");
        Console.WriteLine ("********************************");
        Console.WriteLine ("******* Matyáš Vondráček *******");
        Console.WriteLine ("********************************\n");
        Console.WriteLine ();

        //Vstup od uživatele -špatná varianta
        //Console.WriteLine("Zadejte první číslo řady:");
        //int first = int.Parse(Console.ReadLine());


        //Vstup od uživatele -správná varianta
        Console.WriteLine("Zadejte první číslo řady (celé číslo):");
        int first;
        while (!int.TryParse(Console.ReadLine(),out first)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):");
        }

        Console.WriteLine("Zadejte poslední číslo řady (celé číslo):");
        int last;
        while (!int.TryParse(Console.ReadLine(),out last)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu poslední číslo řady (celé číslo):");
        }

        Console.WriteLine("Zadejte velikost kroku mezi čísly řady (celé číslo):");
        int step;
        while (!int.TryParse(Console.ReadLine(),out step)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu velikost kroku mezi čísly řady (celé číslo):");
        }

        //Výpis uživatelského výstupu
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("První číslo řady: {0}", first);
        Console.WriteLine("Poslední číslo řady: {0}", last);
        Console.WriteLine("Velikost kroku mezi čísly řady: {0}", step);



        //Logika pro výpis řady - TO DO

        //Opakování programu - TO DO
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}