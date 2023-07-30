using System;

public class ClientDetail
{
    public int ClientID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string CellNo { get; set; }
    public string Email { get; set; }
    public int ContractId { get; set; }

    public void PostToDb()
    {
        // Implement the logic to save the client details to the database here
        // For demonstration purposes, let's just display the details for now
        Console.WriteLine("Posting client details to the database...");
        Console.WriteLine($"ClientID: {ClientID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"CellNo: {CellNo}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"ContractId: {ContractId}");
        Console.WriteLine("Client details posted successfully!");
    }
}
