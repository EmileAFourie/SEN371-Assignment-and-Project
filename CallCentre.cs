using System;

public class CallCenter : TicketManagementAndTracking
{
    private DateTime timeStamp;
    private string cellNo;
    private bool isNew;

    public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
    public string CellNo { get => cellNo; set => cellNo = value; }
    public bool IsNew { get => isNew; set => isNew = value; }

    public CallCenter(DateTime timeStamp, string cellNo, bool isNew) : base(timeStamp)
    {
        this.TimeStamp = timeStamp;
        this.CellNo = cellNo;
        this.IsNew = isNew;
    }

    public void AnswerCall(string cellNo, bool isNew)
    {
        // Implementation to start logging a call from a client
    }

    private void EndCall()
    {
        // Implementation to stop logging a call from a client
    }

    public void GetPreviousRequest()
    {
        // Implementation to retrieve the previous ticket logged by a client
    }

    public void CreateTicket(string issueDescription)
    {
        // Implementation to create a new ticket for a client
    }

    public ClientDetail GetClientDetails()
    {
        // Implementation to obtain the client details        
    }
}
