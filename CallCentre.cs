using System;

public class CallCenter
{
    private DateTime timestamp;
    private string phoneNumber;
    private bool isNew;

    public void AnswerCall(string phoneNumber, bool isNew)
    {
        this.timestamp = DateTime.Now;
        this.phoneNumber = phoneNumber;
        this.isNew = isNew;

        Console.WriteLine($"Answering call from {phoneNumber}. Is new call: {isNew}");
    }

    public void EndCall()
    {
        Console.WriteLine($"Ending call from {phoneNumber}");
        // End call
    }

    public void GetPreviousRequest()
    {
        // Retrieve and display the previous request for this phone number
        Console.WriteLine($"Getting previous request for {phoneNumber}");
    }

    public void CreateTicket(string issueDescription)
    {
        // Create a new ticket 
        Console.WriteLine($"Creating ticket for {phoneNumber} - Issue: {issueDescription}");
    }

    public void GetClientDetails()
    {
        // Retrieve client details with their phonenumber
        Console.WriteLine($"Getting client details for {phoneNumber}");
    }
}
