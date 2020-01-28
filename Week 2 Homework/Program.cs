using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_2_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0, input;
            string file = "Tickets.csv";
            string tick, sum, stat, prior, sub, ass, watch;
            do
            {
                //ask for choice
                Console.WriteLine("1. Read The File.\n2. Write a new ticket to file.\n3. Exit\n");
                Int32.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        StreamReader rd = new StreamReader(file);
                        while (!rd.EndOfStream)
                        {
                            string line = rd.ReadLine();
                            string line1 = rd.ReadLine();
                            string[] arr = line1.Split(',');
                            Console.WriteLine($"Ticket ID: {arr[0]}\nSummary: {arr[1]}\nStatus: {arr[2]}\nPriority: {arr[3]}\n" +
                                $"Submitter: {arr[4]}\nAssigned: {arr[5]}\nWatching: {arr[6]}\n");
                            rd.Close();
                            
                        }
                        break;

                    case 2:
                        {
                            StreamWriter rd1 = new StreamWriter(file, append: true);


                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                }
            } while (exit != 0);
        }
    }
}
