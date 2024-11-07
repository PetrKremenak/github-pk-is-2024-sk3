using System.ComponentModel.DataAnnotations;

int velikost,i,j;


Console.Write("napiš velikost pole hvězdy 5-40 ");
velikost=Convert.ToInt32(Console.ReadLine());
if ((velikost > 40) || (velikost < 0))
    {
    Console.WriteLine("hodnota mimo rozsah");
    
}
else
{
    Console.Write("bylo zadáno ");
    Console.WriteLine(velikost);
    char[,] hriste = new char[velikost, velikost];  //definice hriste, dvourozměrné pole ("plocha"), indexy pole jsou souřednice bodu
    int max_i = velikost - 1;                       // maximální index, indexy jsou od 0
    for (i = 0; i <=max_i; i++)                  //zaplň hřiště . (tečkama)
    {
        for (j = 0; j <= max_i; j++)
        {
            hriste[i, j] = '.';
        }
    }
    usecka(0, 0, max_i, 0, hriste);             //vykresli do hřiště úsečku [0,0] ->[max_i,0]
    usecka(0,0, max_i,max_i, hriste);
    usecka(0, max_i,max_i, max_i, hriste);
    usecka(0,max_i, max_i,0, hriste);
    usecka(0, max_i/2,max_i, max_i/2, hriste);

    for (i = 0; i <= max_i; i++)              //tisk  křiště
    {
        for (j = 0; j <= max_i; j++)
        {
            Console.Write(" ");              // mezera, protože znak je jinak široký než výška řádku
            Console.Write(hriste[i, j]) ;
            Console.Write(" ");
        }
        Console.WriteLine();                // nový řádek
    }

 


}
void usecka(int x1,int y1,int x2,int y2,char[,] hriste) //na hřiště vykreslí úsečku mezi body [x1,y1][x2,y2]
{
    int k = x2 - x1;                    //počet bodů v x-ové souřadnici
    int l = y2 - y1;                    //počet bodů v y-ové souřadnici
    int d;
    double krok;
    if (Math.Abs(k) > Math.Abs(l))      //budeme vykreslovat podle většího počtu bodů v dané ose, jinak bychom ztratili některé body v druhé ose
    {
        if (x1 > x2)                    // budeme vykreslovat od menší souřadnice k větší
        {
            d = x1; x1 = x2; x2 = d; d = y1; y1 = y2; y2 = d; // případně body prohodím
        }
        krok = ((double)y1 - (double)y2) / ((double)x1 - (double)x2); // spočítám krok v y-nové souřadnici pro jeden krok v x-ové souřadnici. Celá čísla nutné překonvertovat na desetinná
                                                                       // jinak bychom počítali celočíselně 
        for(int i = 0; i <= x2 - x1; i++)
        {
            int j = y1+Convert.ToInt32((double)i * krok);               // pro každý bod x-ové souřadnice dopočítám y-novou souřadnici bodu
            hriste[i + x1, j] = '*';
        }
     }
     else
    {
        if (y1 > y2)                    // obdoba, ale podle y-nové souřadnice dopočítávám x-ovou
        {
            d = x1; x1 = x2; x2 = d; d = y1; y1 = y2; y2 = d;
        }
        krok = ((double)x1 - (double)x2) / ((double)y1 - (double)y2);
        for (int i = 0; i <= y2 - y1; i++)
        {
            int j = x1 + Convert.ToInt32((double)i * krok);
            hriste[j,y1+i] = '*';
        }
    }
} 
Console.Write("napiš velikost pole písmene Z 5-40 "); // to samé, ale písmeno Z
velikost=Convert.ToInt32(Console.ReadLine());
if ((velikost > 40) || (velikost < 0))
    {
    Console.WriteLine("hodnota mimo rozsah");
    
}
else
{
    Console.Write("bylo zadáno ");
    Console.WriteLine(velikost);
    char[,] hriste = new char[velikost, velikost];  
    int max_i = velikost - 1;                       
    for (i = 0; i <=max_i; i++)                  
    {
        for (j = 0; j <= max_i; j++)
        {
            hriste[i, j] = '.';
        }
    }
    usecka(0, 0, 0, max_i, hriste);             
    usecka(max_i,0, 0,max_i, hriste);
    usecka(max_i, 0,max_i, max_i, hriste);
    

    for (i = 0; i <= max_i; i++)              
    {
        for (j = 0; j <= max_i; j++)
        {
            Console.Write(" ");              
            Console.Write(hriste[i, j]) ;
            Console.Write(" ");
        }
        Console.WriteLine();                
    }
}
Console.Write("napiš velikost pole obráceného písmene Z 5-40 "); // to samé, ale obrácené písmeno Z
velikost=Convert.ToInt32(Console.ReadLine());
if ((velikost > 40) || (velikost < 0))
    {
    Console.WriteLine("hodnota mimo rozsah");
    
}
else
{
    Console.Write("bylo zadáno ");
    Console.WriteLine(velikost);
    char[,] hriste = new char[velikost, velikost];  
    int max_i = velikost - 1;                       
    for (i = 0; i <=max_i; i++)                  
    {
        for (j = 0; j <= max_i; j++)
        {
            hriste[i, j] = '.';
        }
    }
    usecka(0, 0, 0, max_i, hriste);             
    usecka(0,0, max_i,max_i, hriste);
    usecka(max_i, 0,max_i, max_i, hriste);
    

    for (i = 0; i <= max_i; i++)              
    {
        for (j = 0; j <= max_i; j++)
        {
            Console.Write(" ");              
            Console.Write(hriste[i, j]) ;
            Console.Write(" ");
        }
        Console.WriteLine();                
    }
}
Console.Write("napiš velikost pole písmene N 5-40 "); // to samé, ale písmeno N
velikost=Convert.ToInt32(Console.ReadLine());
if ((velikost > 40) || (velikost < 0))
    {
    Console.WriteLine("hodnota mimo rozsah");
    
}
else
{
    Console.Write("bylo zadáno ");
    Console.WriteLine(velikost);
    char[,] hriste = new char[velikost, velikost];  
    int max_i = velikost - 1;                       
    for (i = 0; i <=max_i; i++)                 
    {
        for (j = 0; j <= max_i; j++)
        {
            hriste[i, j] = '.';
        }
    }
    usecka(0, 0, max_i, 0, hriste);             
    usecka(0,0, max_i,max_i, hriste);
    usecka(0, max_i,max_i, max_i, hriste);
    

    for (i = 0; i <= max_i; i++)              
    {
        for (j = 0; j <= max_i; j++)
        {
            Console.Write(" ");              
            Console.Write(hriste[i, j]) ;
            Console.Write(" ");
        }
        Console.WriteLine();                
    }
}
Console.Write("napiš velikost pole obráceného písmene N 5-40 "); //to samé, ale obrácené písmeno N
velikost=Convert.ToInt32(Console.ReadLine());
if ((velikost > 40) || (velikost < 0))
    {
    Console.WriteLine("hodnota mimo rozsah");
    
}
else
{
    Console.Write("bylo zadáno ");
    Console.WriteLine(velikost);
    char[,] hriste = new char[velikost, velikost];  
    int max_i = velikost - 1;                       
    for (i = 0; i <=max_i; i++)                  
    {
        for (j = 0; j <= max_i; j++)
        {
            hriste[i, j] = '.';
        }
    }
    usecka(0, 0, max_i, 0, hriste);             
    usecka(max_i,0, 0,max_i, hriste);
    usecka(0, max_i,max_i, max_i, hriste);
    

    for (i = 0; i <= max_i; i++)              
    {
        for (j = 0; j <= max_i; j++)
        {
            Console.Write(" ");              
            Console.Write(hriste[i, j]) ;
            Console.Write(" ");
        }
        Console.WriteLine();                
    }
}