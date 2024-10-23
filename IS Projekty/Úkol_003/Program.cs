using System;
    class Program
    {
        static void Main ()
        {//int x, y, i;
    Console.WriteLine("Zadejte x");
    int x = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Zadejte y");
    //int y = Convert.ToInt32(Console.ReadLine(14));
    
    for (int i = 0; i <= x; i++){

        for (int j = 0; j < i; j++){
            Console.Write("_ ");
        }
        Console.WriteLine();
    }

        } 
        
    }
   



