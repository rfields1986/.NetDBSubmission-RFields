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
                            string[] arr = line.Split(',');
                            Console.WriteLine($"Ticket ID: {arr[0]}\nSummary: {arr[1]}\nStatus: {arr[2]}\nPriority: {arr[3]}\n" +
                                $"Submitter: {arr[4]}\nAssigned {arr[5]}\nWatching {arr[6]}\n");
                            
                        }
                        break;
                }
            } while (exit != 0);
        }
    }
}
