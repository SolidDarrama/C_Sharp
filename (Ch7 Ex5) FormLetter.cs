using System;


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr4 = new string[6];
            arr4[0] = "Buy it today";
            arr4[1] = "You won't regret your purchase";
            arr4[2] = "Huge Sale Now";
            arr4[3] = "One of a kind products";
            arr4[4] = "Great gift for loved ones";
            arr4[5] = "We have the products you need";

            for (int i = 0; i < arr4.Length; i++)
            {
                int start2 = random.Next(0, arr4);
                Console.Write(start2);
            }

            Console.ReadLine();
        }


    }
}
