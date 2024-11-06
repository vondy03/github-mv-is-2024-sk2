using System;
using System.Diagnostics;
using System.Globalization;

class Program {
    static void Main() {

    string again = "a"; //opakování po stisku klávesky a
    while (again == "a"){
        Console.Clear();
        Console.WriteLine ("********************************");
        Console.WriteLine ("*********** Obrazce ************");
        Console.WriteLine ("********************************");
        Console.WriteLine ("******* Matyáš Vondráček *******");
        Console.WriteLine ("********************************\n");
        Console.WriteLine ();

        //obrazec 1

        Console.WriteLine("Zadejte šířku obrazce (sudé celé číslo):");
        int width1;
        while (!int.TryParse(Console.ReadLine(),out width1 ) || width1 % 2 != 0){
            Console.Write("Nezadali jste celé sudé číslo. Zadejte znovu šířku obrazce (sudé celé číslo):");
        }
       
        Console.WriteLine("Zadejte výšku obrazce (sudé celé číslo):");
        int height1;
        while (!int.TryParse(Console.ReadLine(),out height1)  || height1 % 2 != 0){
            Console.Write("Nezadali jste celé sudé číslo. Zadejte znovu výšku obrazce (sudé celé číslo):");
        }
        
        int polovina1 = width1 / 2;
        for(int i=1; i<=height1 ;i++){
            for(int j=1; j<=width1 ;j++){
                if (i <= (height1 / 2)){
                if (j <= polovina1){
                    Console.Write("  ");
                }
                else
                    Console.Write(" *");
                }
                else
                if(j <= polovina1){
                    Console.Write(" *");
                }
                else {
                    Console.Write("  ");       
                }
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }
            Console.WriteLine();
        }

        //obrazec 2

        Console.WriteLine("Zadejte šířku přesýpacích hodin obrazce (liché celé číslo):");
        int width2;
        while (!int.TryParse(Console.ReadLine(),out width2 ) || width2 % 2 == 0){
            Console.Write("Nezadali jste celé liché číslo. Zadejte znovu šířku obrazce (liché celé číslo):");
        }
        int height2 = width2;
        for (int i = 1; i <= height2; i++) 
        {  
            for (int j = 1; j < i; j++)  
                Console.Write(" ");   
            for (int k = i; k <= width2; k++)  
                Console.Write("* ");  
            Console.WriteLine();
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
        } 
      
        for (int i = height2 - 1; i >= 1; i--)  
        {  
            for (int j = 1; j < i; j++)  
                Console.Write(" ");  
            for (int k = i; k <= width2; k++)  
                Console.Write("* ");  
            Console.WriteLine();
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
        }

        //obrazec 3 

        Console.WriteLine("Zadejte šířku obrazce (celé číslo):");
        int width3;
        while (!int.TryParse(Console.ReadLine(),out width3)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku obrazce (celé číslo):");
        }

        Console.WriteLine("Zadejte výšku obrazce (celé číslo):");
        int height3;
        while (!int.TryParse(Console.ReadLine(),out height3)){
            Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo):");
        }
        for(int i=1; i<=height3 ;i++){
            for(int j=1; j<=width3 ;j++){
                if (i % 2 == 1){
                Console.Write(" *");
                }
                else
                Console.Write("* ");

                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }
            Console.WriteLine();
        }

        Console.WriteLine();
         

        //Opakování programu - TO DO
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }   
    }
}


