using System;
using System.Diagnostics;

class Program {
    static void Main() {

    string again = "a"; //opakování po stisku klávesky a
    while (again == "a"){
        Console.Clear();
        Console.WriteLine ("********************************");
        Console.WriteLine ("*********** Obdélník ***********");
        Console.WriteLine ("********** Trojúhelník *********");
        Console.WriteLine ("********************************");
        Console.WriteLine ("******* Matyáš Vondráček *******");
        Console.WriteLine ("********************************\n");
        Console.WriteLine ();

        //Vstup od uživatele -správná varianta
        Console.WriteLine("Zadejte šířku obrazce (celé číslo):");
        int width;
        while (!int.TryParse(Console.ReadLine(),out width)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku obrazce (celé číslo):");
        }

        Console.WriteLine("Zadejte výšku obrazce (celé číslo):");
        int height;
        while (!int.TryParse(Console.ReadLine(),out height)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo):");
        }

        // for (int i = 1; i<=10 ; i++){
        //     Console.WriteLine(i);
        // }

        // int j = 1;
        // while (j <= 10){
        //     Console.WriteLine(j);
        //     j++;
        // }

        for(int i=1; i<=height ;i++){
            for(int j=1; j<=width ;j++){
                Console.Write("* ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }
            Console.WriteLine();
        }

        Console.WriteLine();


         for(int i=1; i<=height ;i++){
            for (int j=1; j<=i ; j++){
            Console.Write("* ");   
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }
            Console.WriteLine();
        }

        //Opakování programu - TO DO
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}