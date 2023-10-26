using System;
namespace inlämnings_uppgift_3_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet svara J eller N");
            string svar = (Console.ReadLine());
            Console.WriteLine("Hur gammal är du?");
            int svar1 = int.Parse(Console.ReadLine());
            if (svar1 <= 22 && svar1 >= 19)
            {
                Console.WriteLine("Vi vill gärna anställa dig");

            }
            else
            {
                Console.WriteLine("Vi letar tyvär efter annan personal just nu");

            }
            Console.ReadKey();






        }
    }
}