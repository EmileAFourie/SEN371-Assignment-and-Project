using System;

public class Contract
{
    public int ContractID { get; set; }
    public string NameOfContract { get; set; }
    public string Description { get; set; }
    public double Fee { get; set; }

    public void ModifyService(string newName, string newDescription, double newFee)
    {
        // Implement the logic to modify the contract's service details
        // For demonstration purposes, let's just display the updated details for now
        Console.WriteLine($"Modifying service for ContractID: {ContractID}");
        Console.WriteLine($"Old NameOfContract: {NameOfContract}");
        Console.WriteLine($"Old Description: {Description}");
        Console.WriteLine($"Old Fee: {Fee}");

        // Update the contract's service details
        NameOfContract = newName;
        Description = newDescription;
        Fee = newFee;

        Console.WriteLine("Service modified successfully!");
        Console.WriteLine($"New NameOfContract: {NameOfContract}");
        Console.WriteLine($"New Description: {Description}");
        Console.WriteLine($"New Fee: {Fee}");
    }
}
