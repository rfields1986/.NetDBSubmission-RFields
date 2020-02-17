using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_2_Homework
{
    class Ticket
    {
        public string ticketID { get; set; }
        public string ticketSummary { get; set; }
        public string ticketStatus { get; set; }
        public string ticketPriority { get; set; }
        public string submitedBy { get; set; }
        public string assignedTo { get; set; }
        public string watchedBy { get; set; }

        public Ticket(string ticketID, string ticketSummary, string ticketStatus, string ticketPriority, string submittedBy ,string assignedTo, string watchedBy)
        {
            this.ticketID = ticketID;
            this.ticketSummary = ticketSummary;
            this.ticketStatus = ticketStatus;
            this.ticketPriority = ticketPriority;
            this.submitedBy = submittedBy;
            this.assignedTo = assignedTo;
            this.watchedBy = watchedBy;


        }
        public Ticket()
        {
            ticketID = "";
            ticketSummary = "";
            ticketStatus = "";
            ticketPriority = "";
            submitedBy = "";
            assignedTo = "";
            watchedBy = "";

        }
        public void CreateNewTicket()
        {
            string file = "Tickets.csv";
            StreamWriter rd1 = new StreamWriter(file, append: true);
            Console.WriteLine("Please enter your ticket number?");
            ticketID = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a summary of the issue?");
            ticketSummary = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What the status of this ticket?");
            ticketStatus = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a priority: High, Medium, or Low?");
            ticketPriority = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your name?");
            submitedBy = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who is the ticket assigned too?");
            assignedTo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who will be watching this ticket? Seperate multiple watchers with \"|\"");
            watchedBy = Console.ReadLine();
            Console.Clear();
            rd1.WriteLine($"{ticketID},{ticketSummary},{ticketStatus},{ticketPriority},{submitedBy},{assignedTo},{watchedBy}");
            rd1.Close();
            Console.WriteLine("Press Enter To Return To The Main Menu");
            Console.ReadKey();
            
        }


    }
}
