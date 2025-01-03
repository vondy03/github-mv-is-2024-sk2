﻿using System;
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
        while (!int.TryParse(Console.ReadLine(),out n) || n <= 0){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu počet generovaných čísel (kladné celé číslo):");
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
        int negative = 0;
        int positive = 0;
        int zeroes = 0;
        int suda = 0;
        int licha = 0;

        Console.WriteLine("Náhodná čísla: ");
        for (int i = 0; i < n; i++)
        {
        myArray[i] = randomNumber.Next(dm, hm+1);
        Console.Write("{0}; ", myArray[i]);
        if (myArray[i] > 0)
            positive ++;
        else
        if (myArray[i] < 0)
            negative ++;
        else
            zeroes ++;

        if(myArray[i] % 2 == 0)
            suda++;
        else
            licha++;
        }
        Console.WriteLine("\n");

        int posMax = myArray[0];
        int posMin = myArray[0];
        int maximum = myArray[0];
        for (int i = 1; i < n; i++)
        {
        if (myArray[i] > maximum){
            maximum = myArray[i];
            posMax = i;
        }
        }
        Console.WriteLine("Maximální hodnata je: {0}\n", maximum);
        Console.WriteLine("Maximum je na pozici: {0}\n", posMax);


        int minimum = myArray[0];
        for (int i = 1; i < n; i++)
        {
        if (myArray[i] < minimum){
            minimum = myArray[i];
            posMin = i;
        }
        }
        Console.WriteLine("Minimální hodnota je: {0}\n", minimum);
        Console.WriteLine("Minimum je na pozici: {0}\n", posMin);







        //Výpis uživatelského vstupu
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine("Uživatelský vstup:");
        Console.WriteLine("Počet čísel: {0}; dolní mez {1}; horní mez {2}", n, dm ,hm);
        Console.WriteLine("Počet čísel sudých: {0}; počet čísel lichých {1}", suda, licha);
        Console.WriteLine("=====================================\n\n");
        Console.WriteLine("Počet kladných čísel: {0}, počet záporných čísel: {1}, počet nul: {2}\n\n", positive, negative, zeroes);


        //Opakování programu - TO DO
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}