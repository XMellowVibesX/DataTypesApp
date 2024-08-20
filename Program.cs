// See https://aka.ms/new-console-template for more information
using System;

namespace CasabarDataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            // Fruit Prices (Variables)
            const double applePrice = 3.00;
            const double avocadoPrice = 10.00;
            const double kiwiPrice = 4.00;
            const double lemonPrice = 8.00;
            const double orangePrice = 6.00;

            // Welcome Message
            Console.WriteLine(
                "======================================\n" +
                "\tWelcome to Fruit Mart!\n"+
                "======================================\n" +
                "\n"+
                "Type out how many fruits you want in the spaces below,\n"+
                "Just type 0 if you don't want any. Thank you, valued customer!"
                );


            // Fruit selection
            Console.WriteLine(
                "1. Apples, P3.00/pc \n" +
                "2. Avocado, P10.00/pc \n" +
                "3. Kiwi, P4.00/pc \n" +
                "4. Lemon, P8.00/pc \n" +
                "5. Oranges, P6.00/pc \n"
                );


            // User Input for fruit amount
            Console.Write("Apples: ");
            int appleAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Avocado: ");
            int avocadoAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kiwi: ");
            int kiwiAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lemon: ");
            int lemonAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Oranges: ");
            int orangeAmount = Convert.ToInt32(Console.ReadLine());


            // Multiplying the amount of fruits to their price
            double appleTotalPrice = appleAmount * applePrice;
            double avocadoTotalPrice = avocadoAmount * avocadoPrice;
            double kiwiTotalPrice = kiwiAmount * kiwiPrice;
            double lemonTotalPrice = lemonAmount * lemonPrice;
            double orangeTotalPrice = orangeAmount * orangePrice;

            // Adding all the totals together for the overall total
            double overallTotal = appleTotalPrice+avocadoTotalPrice+kiwiTotalPrice+lemonTotalPrice+orangeTotalPrice;

            // Displaying the multiplication
            Console.WriteLine("\n RECEIPT: \n" +
                "======================================\n" +
                appleAmount + " Apple(s) x " + applePrice + " = P" + appleTotalPrice + "\n" +

                avocadoAmount + " Avocado(es) x " + avocadoPrice + " = P" + avocadoTotalPrice + "\n" +

                kiwiAmount + " Kiwi(s) x " + kiwiPrice + " = P" + kiwiTotalPrice + "\n" +

                lemonAmount + " Lemon(s) x " + lemonPrice + " = P" + lemonTotalPrice + "\n" +

                orangeAmount + " Orange(s) x " + orangePrice + " = P" + orangeTotalPrice + "\n" +

                "======================================\n" +
                "TOTAL: P" + overallTotal +
                "\nPLEASE PROCEED TO CHECKOUT :)"
                );
        }
    }
}