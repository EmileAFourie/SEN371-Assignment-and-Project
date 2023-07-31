using System;

public class CallCenter
{
    private DateTime timeStamp;
    public string cellNo;
    protected bool isNew;

    public void AnswerCall(string cellNo, bool isNew)
    {
        //Implementation to start loging a call from a client
    }

    private void EndCall()
    {
        //Implementation to stop logging a call from a client
    }

    public void GetPreviousRequest()
    {
       //Implementation to retrieve the previous ticket logged by a client
    }

    public void CreateTicket(string issueDescription)
    {
       //Implementation to create a new ticket for a client
    }

    public ClientDetail GetClientDetails()
    {
        //Implementation to obtain the client details
    }
}
