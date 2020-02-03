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
                Console.Clear();
                Console.WriteLine("1. Read The File.\n2. Write a new ticket to file.\n3. Exit\n");
                Int32.TryParse(Console.ReadLine(), out input);
                Console.Clear();
                switch (input)
                {
                    case 1:
                        exit = 1;
                        StreamReader rd = new StreamReader(file);
                        string line = rd.ReadLine();
                        string[] header = line.Split(',');
                        while (!rd.EndOfStream)
                        {
                            string line1 = rd.ReadLine();
                            string[] body = line1.Split(',');
                            for (int i = 0; i < body.Length; i++)
                            {
                                Console.Write("{0,-20}",header[i]) ;
                                Console.WriteLine(body[i]);

                            }
                            Console.WriteLine("\n");




                        }
                        Console.WriteLine("Press Enter To Return To The Main Menu");
                        Console.ReadKey();
                        rd.Close();
                        break;

                    case 2:
                        {
                            exit = 1;
                            StreamWriter rd1 = new StreamWriter(file, append: true);
                            string ticketID, summary, status, priority, submitter, assigned, watching;
                            Console.WriteLine("Please enter your ticket number?");
                            ticketID = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Please enter a summary of the issue?");
                            summary = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("What the status of this ticket?");
                            status = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Please enter a priority: High, Medium, or Low?");
                            priority = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("What is your name?");
                            submitter = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Who is the ticket assigned too?");
                            assigned = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Who will be watching this ticket? Seperate multiple watchers with \"|\"");
                            watching = Console.ReadLine();
                            Console.Clear();
                            rd1.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{watching}");
                            rd1.Close();
                            Console.WriteLine("Press Enter To Return To The Main Menu");
                            Console.ReadKey();

                        }
                        break;
                    case 3:
                        {
                            exit = 0;
                            Console.WriteLine("Goodbye");
                        }
                        break;
                }
            } while (exit != 0);
        }
    }
}
