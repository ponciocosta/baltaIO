using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        //Function Menu
        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("## Stopwatch Menu ##");
            Console.WriteLine("S = Seconds. Sample(typing 10s equals 10 seconds)");
            Console.WriteLine("M = Minutes. Sample(typing 1m equals 1 minute)");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("\n -----------------");
            Console.WriteLine("Type an option:");

            string res = Console.ReadLine().ToLower();
            //Console.WriteLine(res);
            if (res == "0") {
                Console.WriteLine("End of Process.");
                System.Environment.Exit(0);
            }
            else{ 
                char type = char.Parse(res.Substring(res.Length - 1,1));
                int time = int.Parse(res.Substring(0,res.Length - 1));
                int multiplier = 1;
                Console.WriteLine(type);
                Console.WriteLine(time);

                //Verifying type
                if(type == 'm')
                    multiplier = 60;
            
                PreStart(time * multiplier);
            }

        }

        //Functino PreStart
        static void PreStart(int time)
        {
            Console.Clear ();
            Console.WriteLine("Ready...");
            Thread.Sleep (1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO...");
            Thread.Sleep(1000);
            Start(time);
        }

        //Function Start
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished");
            Thread.Sleep(2500);
            Menu();
        }

    }
}
