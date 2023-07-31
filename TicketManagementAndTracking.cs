using System;

public class TicketManagementAndTracking
{
    public int ClientID { get; set; }
    public string TypeOfError { get; set; }
    public string Description { get; set; }
    public string Priority { get; set; }
    public string State { get; set; }
    public int TicketID { get; set; }

    public void LogTicket()
    {
        Console.WriteLine("Logging the ticket...");
        Console.WriteLine($"TicketID: {TicketID}");
        Console.WriteLine($"ClientID: {ClientID}");
        Console.WriteLine($"TypeOfError: {TypeOfError}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Priority: {Priority}");
        Console.WriteLine($"State: {State}");
        Console.WriteLine("Ticket logged successfully!");
    }

    public void ManagePriority(string newPriority)
    {
        Console.WriteLine("Managing ticket priority...");
        Console.WriteLine($"TicketID: {TicketID}");
        Console.WriteLine($"Old Priority: {Priority}");
        Console.WriteLine($"New Priority: {newPriority}");

        Priority = newPriority; 
        Console.WriteLine("Ticket priority managed successfully!");
    }
}
