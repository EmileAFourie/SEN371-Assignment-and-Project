using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

class Program
{
    /* string accountSid = "AC23b601fb4dbe7e1c1e5ead51dae7dba7";
    string authToken = "9790543c1792b1065cf53bdae165aef9"; */
    private const string accountSid = "ACd84e3e785bb900fc451780701904ca2e"; //Leandro's Trail Account
    private const string authToken = "770a0a9aef88cbeac2f638ffcc3ba2cf";

    static void Main(string[] args)
    {
        // Initialize the Twilio client
        TwilioClient.Init(accountSid, authToken);

        // New job details
        string TicketID = "12345";
        string Description = "Install new HVAC system";

        // Employee's phone numbers 
        string technician1PhoneNumber = "+27763237618";       

        // Compose SMS message
        string smsMessage = $"New ticket available!\nJob ID: {TicketID}\nDescription: {Description}";

        // Send SMS notifications to technicians
        SendMessage(technician1PhoneNumber, smsMessage);
        
        Console.WriteLine("SMS notifications sent to Employee.");
    }
    static void SendMessage(string toPhoneNumber, string message)
    {
        var messageOptions = new CreateMessageOptions(
            new Twilio.Types.PhoneNumber(toPhoneNumber))
        {
            Body = message,
            From = new Twilio.Types.PhoneNumber("+13344893749") // Add your Twilio phone number here
        };

        var sentMessage = MessageResource.Create(messageOptions);
    }

    public bool SendClientTicket(TicketManagementAndTracking ticket)
    {
        //string phone = "+27" + ticket.cellNo(1, 9);
        string phone = "+27740136580";

        try
        {
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: $"\nPremier Service Solutions - There has been a update to one of your tickets: \nTicket {ticket.TicketID} has " +
                " moved to {ticket.Status.ToLower()} at {ticket.DateClosed}",
                from: new Twilio.Types.PhoneNumber("+18156459747"),
                to: new Twilio.Types.PhoneNumber(phone)
            );
            return true;
        }
        catch
        {
            return false;
        }
    }

}


