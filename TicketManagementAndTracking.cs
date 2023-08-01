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
    
    public TicketManagementAndTracking(int clientID, string typeOfErr, string description, DateTime dateOpened, string priority, string status, int ticketID)
    {
        this.ClientID = clientID;
        this.TypeOfErr = typeOfErr;
        this.Description = description;
        this.DateOpened = dateOpened;
        this.Priority = priority;
        this.Status = status;
        this.TicketID = ticketID;
    }

    public int ClientID1 { get => ClientID; set => ClientID = value; }
    public string TypeOfErr1 { get => TypeOfErr; set => TypeOfErr = value; }
    public string Description1 { get => Description; set => Description = value; }
    public DateTime DateOpened1 { get => DateOpened; set => DateOpened = value; }
    public DateTime DateClosed1 { get => DateClosed; set => DateClosed = value; }
    public string Priority1 { get => Priority; set => Priority = value; }
    public string Status1 { get => Status; set => Status = value; }
    public int TicketID1 { get => TicketID; set => TicketID = value; }

    
    public void LogTicket(int clientID, string typeOfErr, string description, DateTime dateOpened, string priority)
    {
       
    }

   public void AssignTicketToEmployee(int ticketID, int employeeID)
    {
        
    }

   public void UpdateTicketStatus(int ticketID, string status)
    {
        
    }

   public static List<TicketManagementAndTracking> allTicketsList = new List<TicketManagementAndTracking>();

 
    public TicketManagementAndTracking GetTicket(int ticketID)
    {
       
    }

     public List<TicketManagementAndTracking> GetAllOpenTickets()
    {
        
    }

    public List<TicketManagementAndTracking> GetAssignedTickets(int employeeID)
    {
       
    }

    public void ManagePriority(int ticketID, string priority)
    {
        
    }

  
    private int GenerateTicketID()
    {
       
    }

    public TicketManagementAndTracking FindTicketByID(int ticketID)
    {
        
    }
}
