using System;

public class TicketingSystem
{
    public static void Main()
    {
        InfoManager infoManager = new InfoManager();

        string ticketinfo = "ticketinfo.txt";
        string menu;

      



                do
        {
            Console.WriteLine("1. Edit File");
            Console.WriteLine("2. Read File");
            Console.WriteLine("3. Exit System");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                infoManager.Write(ticketinfo);

            }
            else if (menu == "2")
            {
                infoManager.Read(ticketinfo);

            }
            else if (menu == "3")
            {

            }


        } while (menu != "3");

    }
}

