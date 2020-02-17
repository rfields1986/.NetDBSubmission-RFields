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
                        ReadTicketFile();

                        break;

                    case 2:
                        {
                            exit = 1;
                            Ticket ticketEntry = new Ticket();
                            ticketEntry.CreateNewTicket();

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
        public static void ReadTicketFile()
        {
            string file = "Tickets.csv";
            StreamReader rd = new StreamReader(file);
            string line = rd.ReadLine();
            string[] header = line.Split(',');
            while (!rd.EndOfStream)
            {
                string line1 = rd.ReadLine();
                string[] body = line1.Split(',');
                for (int i = 0; i < body.Length; i++)
                {
                    Console.Write("{0,-20}", header[i]);
                    Console.WriteLine(body[i]);

                }
                Console.WriteLine("\n");




            }
            Console.WriteLine("Press Enter To Return To The Main Menu");
            Console.ReadKey();
            rd.Close();
        }

    }
}
