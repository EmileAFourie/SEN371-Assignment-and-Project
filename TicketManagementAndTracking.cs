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
        // Implement the logic to log the ticket and save it to the database or ticketing system
        // For demonstration purposes, let's just display the ticket details for now
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
        // Implement the logic to update the priority of the ticket
        // For demonstration purposes, let's just display the new priority for now
        Console.WriteLine("Managing ticket priority...");
        Console.WriteLine($"TicketID: {TicketID}");
        Console.WriteLine($"Old Priority: {Priority}");
        Console.WriteLine($"New Priority: {newPriority}");
        Priority = newPriority; // Updating the priority field
        Console.WriteLine("Ticket priority managed successfully!");
    }
}
