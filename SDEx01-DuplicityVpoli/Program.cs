using System;

namespace SDEx01_DuplicityVpoli
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array2 = { 1, 3, 15, 5, 3, 9, 15, 10, 8, 8, 3, 146, 146};
            int[] opakujiciSe = new int[array2.Length];

            //vypis analyzoanych cisel

            Console.WriteLine("Z techto cisel najdi ty, ktere se tam opakuji:");

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            
            //v poli zustanou jen opakujici se cisla a nuly
            for (int i = 0; i < array2.Length; i++)
            {
                for (int i2 = 0; i2 < array2.Length; i2++)
                {
                    if (i != i2)
                    {
                        if (array2[i]==array2[i2])
                        {
                            opakujiciSe[i] = array2[i2];
                        }
                    }
                }
            }
           
            //setridim od nejmensiho po nejvetsi, bublle sort
            bool serazeno =false;
            int pom;               

            do
            {
                serazeno = true;
                for (int i = 0; i < opakujiciSe.Length-1; i++)
                {
                    if (opakujiciSe[i]>opakujiciSe[i+1])
                    {
                        pom = opakujiciSe[i];
                        opakujiciSe[i] = opakujiciSe[i + 1];
                        opakujiciSe[i + 1] = pom;
                        serazeno = false;
                    }
                }
            } while (serazeno == false);
            
            // bez duplicit
            Console.WriteLine("Tyto cisla se v seznamu opakuji:");
            for (int i = 1; i < opakujiciSe.Length; i++)
            {
                if (opakujiciSe[i]!=0)
                {
                    if (opakujiciSe[i]!=opakujiciSe[i-1])
                    {
                        Console.WriteLine(opakujiciSe[i]);
                    }
                }
            }





            







        }
    }
}
