using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class TicketLimit
    {
        static void Main(string[] args)
        {
            Summer Summer = new Summer();
            try
            {
                Summer.CalculateTicket();
            }
            catch (TicketLimt e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
    public class TicketLimt : ApplicationException
    {
        public TicketLimt(string massage)
            : base(massage)
        {

        }
    }
    public class Summer
    {
        int TotalTickets = 10;
        int count = 0;
        char choice = 'Y';
        public void CalculatetICKET()
        {
            while (true)
            {
                Console.WriteLine("dO you want to book the tickets(Y/N)");
                choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'Y' || choice == 'Y')
                {
                    Console.WriteLine("Only {0} tickets are available", TotalTickets);
                    Console.WriteLine("enter the number of tickets you want to book");
                    count = Convert.ToInt32(Console.ReadLine());
                    if (count > TotalTickets)
                        throw (new TicketLimt("Tickets not available"));
                    else
                        TotalTickets -= count;
                }
                else
                    break;
            }
        }
    }
}
