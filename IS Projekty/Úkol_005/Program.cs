string again = "a";
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("********************");
            Console.WriteLine("********************");
            Console.WriteLine("***Petr Křemenák****");
            Console.WriteLine("********************");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Zadejte text pro analýzu ");
            string MujText =Console.ReadLine();

            Console.WriteLine(MujText);
            Console.WriteLine(MujText[0]);
            Console.WriteLine(MujText.Length);
            Console.WriteLine(MujText[MujText.Length-1]);
            string samohlasky = "aeiou";
            string souhlasky = "bflmpsvz";
            string cislice = "0123456789";
            int pocet_souhlasek = 0;
            int pocet_samohlasek = 0;
            int pocet_cislic = 0;
            int pocet_ostatni = 0;

            foreach(char znak in MujText){
                if(souhlasky.Contains(znak)){
                pocet_souhlasek++;
                }
                else if(samohlasky.Contains(znak)){
                pocet_samohlasek++;
                }
                else if(cislice.Contains(znak)) {
                pocet_cislic++;
                }
                else{pocet_ostatni++;}
            }
            Console.WriteLine("\n\nPočet souhlásek {0}", pocet_souhlasek);
            Console.WriteLine("\n\nPočet samohlásek: {0}", pocet_samohlasek);
            Console.WriteLine("\n\nPočet čísel: {0}", pocet_cislic);
            Console.WriteLine("\n\nPočet samohlásek: {0}", pocet_ostatni);

        }