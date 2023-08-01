using System;
// ###############
// ###############
// ###############

// this is now the base class

// ###############
// ###############
// ###############
// ###############

public class CallCenter : ClientDetail
{
    private DateTime timeStamp;
    private string cellNo;
    private bool isNew;
    private  int TickectID; 

    public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
    public string CellNo { get => cellNo; set => cellNo = value; }
    public bool IsNew { get => isNew; set => isNew = value; }

    public int TickecID { get => TickecID; set => TickecID = value; }

    public CallCenter(DateTime timeStamp, string cellNo, bool isNew,int TickecID, int clientID, string name, string address, string email, string clientType, int contractId) 
        : base(clientID, name, address, cellNo, email, clientType, contractId)
    {
        this.TimeStamp = timeStamp;
        this.CellNo = cellNo;
        this.IsNew = isNew;
        this.TickecID = TickecID;
    }

    public void AnswerCall(string cellNo, bool isNew)
    {
        // Implementation to start logging a call from a client
    }

    private void EndCall()
    {
        // Implementation to stop logging a call from a client
    }

// do enum for isNEw in program to decide which method to use 

    public void GetPreviousRequest(bool isNew)
    {
        // Implementation to retrieve the previous ticket logged by a client
    }

    public void CreateTicket(string issueDescription)
    {
        // Implementation to create a new ticket for a client
    }

    public new ClientDetail GetClientDetails()
    {
        // Implementation to obtain the client details        
    }

    public void CreateNewClient()
    {
        // Create a new client 
    }
   
}
