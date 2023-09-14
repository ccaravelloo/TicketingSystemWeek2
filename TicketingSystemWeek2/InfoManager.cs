// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

public class InfoManager
{
    

    public void Write(string ticketinfo)
    {
        StreamWriter sw = new StreamWriter(ticketinfo, true);
        Console.WriteLine("Enter TicketID:");
        var ticketID = Console.ReadLine();

        Console.WriteLine("What is the ticket:");
        var ticketSummary = Console.ReadLine();

        Console.WriteLine("Ticket status:");
        var ticketStatus = Console.ReadLine();

        Console.WriteLine("Ticket priority:");
        var ticketPriority = Console.ReadLine();

        Console.WriteLine("Ticket Submitter:");
        var ticketSubmitter = Console.ReadLine();

        Console.WriteLine("Ticket Assigned:");
        var ticketAssigned = Console.ReadLine();

        Console.WriteLine("Who is watching");
        Console.ReadLine();
        Console.WriteLine("Is anyone else watching? y/n");
        string selection;
        do
        {
            selection = Console.ReadLine();

            if (selection == "y")
            {
                Console.WriteLine("Who is watching");
                Console.ReadLine();
            }
            if (selection == "n")
            {
                break;
            }
        } while (selection != "n");


        sw.Close();
}
    public void Read(string ticketinfo)
    {
        if (File.Exists(ticketinfo))
        {
            StreamReader sr = new StreamReader(ticketinfo);
            Console.WriteLine(Write);

           


        }
    }
}