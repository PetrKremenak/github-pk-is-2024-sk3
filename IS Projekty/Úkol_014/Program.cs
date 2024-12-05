string again = "a";
        while(again == "a") {
            Console.Clear();
            razítko();
            ulong a = ziskatCislo("Zadejte přirozené číslo a:");
            ulong b = ziskatCislo("Zadejte přirozené číslo b:");
           ulong nsd = vypocitatNsd(a, b);
           ulong nsn = vypocitatnsn(a, b, nsd);
            zobrazitvysledky(a,b, nsd, nsn);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }
static void razítko() {
            Console.WriteLine("****************************");
            Console.WriteLine("**** Výpis číselné řady ****");
            Console.WriteLine("****** Křemenák Petr *******");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();
}

static ulong ziskatCislo(string zprava) {
     ulong number;
      Console.Write(zprava);
    while(!ulong.TryParse(Console.ReadLine(), out number)) {
           Console.Write("Nezadali jste celé číslo. Zadejte číslo (celé číslo): ");
            }
    
    
    Console.WriteLine();
    return number;
}
static ulong vypocitatNsd(ulong a, ulong b){
while(a!=b){
    if (a>b){
        a = a - b;
    }
    else {
        b = b - a;
    }
}
return a;
}
static ulong vypocitatnsn(ulong a, ulong b, ulong nsd){
    return (a*b)/nsd;
}
static void zobrazitvysledky (ulong a, ulong b, ulong nsd, ulong nsn){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"NSD čísel {a} a {b} je {nsd}");
    Console.WriteLine();




    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("NSN čísel {0} a {1} je {2}", a, b, nsn);
    Console.WriteLine();


    Console.ForegroundColor = ConsoleColor.White;
}
