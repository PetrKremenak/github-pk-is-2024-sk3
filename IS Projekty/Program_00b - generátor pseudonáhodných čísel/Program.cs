using System;

class Program{
    static void Main(string[] args){
        string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
            Console.WriteLine("************** Křemenák Petr ************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu (celé číslo): ");
            }



            
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("========================================================\n\n");
            
            //Deklarace pole o velikosti n-prvků
            int[] MyArray = new int[n];
            
            // příprava pro generátor náhodných čísel
            Random randomNumber = new Random();
            for (int i = 0; i<n; i++){
                MyArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0};", MyArray[i]);
            }
            int max = MyArray[0];
            int min = MyArray[0];
            int posMax = 0;
            int posMin = 0;
            for(int i = 1; i < n; i++){
                if(MyArray[i] > max){
                    max = MyArray[i];
                }
                if(MyArray[i] < min){
                    min = MyArray[i];
                }
            Console.WriteLine("\n\n Maximum = {0}, Pozice čísla v poli{1}", max, posMax);
            Console.WriteLine("Minimum = {0}, Pozice čísla v poli {1}", min, posMax);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    
            
        
    

    }

    

    
}