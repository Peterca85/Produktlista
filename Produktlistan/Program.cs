using System;

namespace Produktlistan;
class Program
{
    static void Main(string[] args)
    {

        // skapar en Array
        String[] products = new string[5];


        Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'");


        // skapar en while loop
        while (true)
        {


            // Tar användarens input och omvandlar den till småbokstäver och tar bort mellanrum.
            String product = Console.ReadLine().ToLower().Trim();


            if (ValidateInput(product))
            {
                // kontrollerar om input är=exit och stänger program.
                if (product == "exit")
                {
                    break;

                }

                //ökar storleken på arrayen med +1
                Array.Resize(ref products, products.Length + 1);

                // lägger till produkten i Arrayen.
                products[products.Length - 1] = product;


            }




        }


        Console.WriteLine("Du angav följande produkter (sorterade)");

        // sorterar Arrayerna i bokstavsordning
        Array.Sort(products);


        // loopar igenom produktlistan med en foreach loop och skriver ut varje produkt.
        foreach (String p in products)
        {
            //om produkten har ett värde. skriv ut den med stora bokstäver.
            if (p != null)
            {
                Console.WriteLine("* " + p.ToUpper());
            }
        }
    }

    // metod för att validera användarens input
    static bool ValidateInput(String product)
    {
        // kontrollerar om användarens input är tom
        if (string.IsNullOrEmpty(product))
        {
            Console.WriteLine("Det får inte vara ett tomt värde");
            return false;
        }




        return true;
    }

}