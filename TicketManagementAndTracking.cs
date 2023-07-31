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
