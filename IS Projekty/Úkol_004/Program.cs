using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program{
    static void Main(string[] args){
        string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Převod z desítkové do dvojkové  ****");
            Console.WriteLine("************** Křemenák Petr ************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte čísla na převod do dvojkové soustavy ");
            ;
            int n;
            uint cislo = Convert.ToUInt32(Console.ReadLine());
            uint zaloha = cislo;
            uint zbytek;
            uint[] myArray = new uint[32];
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            



            
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("========================================================\n\n");
            uint i=0;
            while(cislo > 0){
                zbytek = cislo % 2;
                cislo = (cislo - zbytek) / 2;
                myArray[i] = zbytek;

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Celá část = {0}, zbytek = {1}", cislo, zbytek);
    
                i++;
            }
            Console.WriteLine("\n Poslední použitá buňka pole {0}", i-1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Číslo {0} převedené do binární soustavy", zaloha);
            for (uint j = i-1; j>=0 ; j-- ){
                Console.WriteLine("{0}", myArray[j]);
            }





            }
        
    

    }

    

    
}