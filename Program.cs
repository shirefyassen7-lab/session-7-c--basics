using System.ComponentModel.Design;
using System.Diagnostics;
using System.Threading.Channels;

namespace session07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int secret = 66;
            int guessleft = 3;


            while (guessleft > 0)
            {
                Console.WriteLine($"guess the secret {guessleft} tries left : ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine("its true");
                    break;
                }
                else if (guess < secret)
                {
                    Console.WriteLine("too low");
                }
                else
                    Console.WriteLine("too high");

                guessleft--;
            }
            if (guessleft == 0)
                Console.WriteLine("game over");






            string massage = null;
            Console.WriteLine(massage?.Length);

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("fizzbuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("buzz");
                else Console.WriteLine(i);
            }


        }
    }
}
