using System;

public class CallCenter
{
    private DateTime timeStamp;
    private string cellNo;
    public bool isNew;

    public void AnswerCall(string cellNo, bool isNew)
    {
        this.timeStamp = DateTime.Now;
        this.cellNo = cellNo;
        this.isNew = isNew;

        Console.WriteLine($"Answering call from {cellNo}. Is new call: {isNew}");
    }

    private void EndCall()
    {
        Console.WriteLine($"Ending call from {cellNo}");
        // Perform any necessary cleanup or logging here
    }

    public void GetPreviousRequest()
    {
        // Retrieve and display the previous request for this phone number
        Console.WriteLine($"Getting previous request for {cellNo}");
    }

    public void CreateTicket(string issueDescription)
    {
        // Create a new ticket with the provided issue description
        Console.WriteLine($"Creating ticket for {cellNo} - Issue: {issueDescription}");
    }

    public void GetClientDetails()
    {
        // Retrieve and display client details based on the phone number
        Console.WriteLine($"Getting client details for {cellNo}");
    }
}
