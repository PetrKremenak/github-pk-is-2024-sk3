using System;
    class Program
    {
        static void Main ()
        {
    Console.WriteLine("Zadejte x");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Zadejte y");
    int y = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i <= x; i++){

        for (int j = 0; j < i; j++){
            Console.Write("_ ");
        }
        Console.WriteLine();

    for (int z = 0; z <= x; y++){

        for (int p = 0; p <= y; p++){
            Console.Write("_ ");
        }
        Console.WriteLine();
    }

        } 
        
    }
    }
   



