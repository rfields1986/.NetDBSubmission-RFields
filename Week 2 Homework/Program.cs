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
                            string line1 = rd.ReadLine();
                            string[] arr = line1.Split(',');
                            Console.WriteLine($"Ticket ID: {arr[0]}\nSummary: {arr[1]}\nStatus: {arr[2]}\nPriority: {arr[3]}\n" +
                                $"Submitter: {arr[4]}\nAssigned: {arr[5]}\nWatching: {arr[6]}\n");
                            
                            
                        }
                        rd.Close();
                        break;

                    case 2:
                        {
                            StreamWriter rd1 = new StreamWriter(file, append: true);
                            string ticketID, summary, status, priority, submitter, assigned, watching;
                            Console.WriteLine("Please enter your ticket number?");
                            ticketID = Console.ReadLine();
                            Console.WriteLine("Please enter a summary of the issue?");
                            summary = Console.ReadLine();
                            Console.WriteLine("What the status of this ticket?");
                            status = Console.ReadLine();
                            Console.WriteLine("Please enter a priority: High, Medium, or Low?");
                            priority = Console.ReadLine();
                            Console.WriteLine("What is your name?");
                            submitter = Console.ReadLine();
                            Console.WriteLine("Who is the ticket assigned too?");
                            assigned = Console.ReadLine();
                            Console.WriteLine("Who will be watching this ticket?");
                            watching = Console.ReadLine();
                            rd1.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{watching}");
                            rd1.Close();

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
