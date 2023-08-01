using System;
public class TicketManagementAndTracking
 
{   
    private int ClientID;
    private string TypeOfErr;
    private string Description;
    private DateTime DateOpened;
    private DateTime DateClosed;
    private string Priority;
    private string Status;
    private int TicketID;
    
   public static List<TicketManagementAndTracking> allTicketsList = new List<TicketManagementAndTracking>();

    public int ClientID1 { get => ClientID; set => ClientID = value; }
    public string TypeOfErr1 { get => TypeOfErr; set => TypeOfErr = value; }
    public string Description1 { get => Description; set => Description = value; }
    public DateTime DateOpened1 { get => DateOpened; set => DateOpened = value; }
    public DateTime DateClosed1 { get => DateClosed; set => DateClosed = value; }
    public string Priority1 { get => Priority; set => Priority = value; }
    public string Status1 { get => Status; set => Status = value; }
    public int TicketID1 { get => TicketID; set => TicketID = value; }

    public TicketManagementAndTracking(int clientID, string typeOfErr, string description, DateTime dateOpened, DateTime dateClosed, string priority, string status, int ticketID)
    {
        ClientID1 = clientID;
        TypeOfErr1 = typeOfErr;
        Description1 = description;
        DateOpened1 = dateOpened;
        DateClosed1 = dateClosed;
        Priority1 = priority;
        Status1 = status;
        TicketID1 = ticketID;
    }

    public void LogTicket(int clientID, string typeOfErr, string description, DateTime dateOpened, string priority)
    {
       //Log a new ticket with provided details.
    }

   public void AssignTicketToEmployee(int ticketID, int employeeID)
    {
        //Assign a ticket to an employee with the given ticketID and employeeID.
    }

   public void UpdateTicketStatus(int ticketID, string status)
    {
        //Update the status of a ticket with the given ticketID.
    }   

   public TicketManagementAndTracking GetTicket(int ticketID)
    {
       //Get the ticket with the given ticketID.
    }

     public List<TicketManagementAndTracking> GetAllOpenTickets()
    {
     //Get a list of all open tickets.   
    }

    public List<TicketManagementAndTracking> GetAssignedTickets(int employeeID)
    {
       //Get a list of tickets assigned to the employee with the given employeeID.
    }

    public void ManagePriority(int ticketID, string priority)
    {
        //Manage the priority of a ticket with the given ticketID.
    }

  
    private int GenerateTicketID()
    {
       //Generate a new unique ticketID.
    }

    public TicketManagementAndTracking FindTicketByID(int ticketID)
    {
        //Find the ticket with the given ticketID and return the ticket object.
    }
}


    
    
