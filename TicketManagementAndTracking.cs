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
        int newTicketID = GenerateTicketID(); 
        TicketManagementAndTracking newTicket = new TicketManagementAndTracking(clientID, typeOfErr, description, dateOpened, priority, "Open", newTicketID);
        allTicketsList.Add(newTicket);
        Console.WriteLine("Ticket with ID " + newTicketID + " logged successfully.");
    }

   public void AssignTicketToEmployee(int ticketID, int employeeID)
    {
        TicketManagementAndTracking ticketToAssign = FindTicketByID(ticketID);
        if (ticketToAssign != null)
        {
            ticketToAssign.EmployeeID = employeeID;
            ticketToAssign.Status = "Assigned";            
            Console.WriteLine("Ticket with ID " + ticketID + " assigned to employee with ID " + employeeID);
        }
        else
        {
            Console.WriteLine("Ticket with ID " + ticketID + " not found.");
        }
    }

   public void UpdateTicketStatus(int ticketID, string status)
    {
        TicketManagementAndTracking ticketToUpdateStatus = FindTicketByID(ticketID);
        if (ticketToUpdateStatus != null)
        {
            ticketToUpdateStatus.Status = status;

            if (status == "Closed")
            {
                ticketToUpdateStatus.DateClosed = DateTime.Now;
            }
            else
            {
                ticketToUpdateStatus.DateClosed = null;
            }
            Console.WriteLine("Ticket with ID " + ticketID + " status updated to: " + status);
        }
        else
        {
            Console.WriteLine("Ticket with ID " + ticketID + " not found.");
        }
    }

   public static List<TicketManagementAndTracking> allTicketsList = new List<TicketManagementAndTracking>();

   public TicketManagementAndTracking GetTicket(int ticketID)
    {
        TicketManagementAndTracking ticketToRetrieve = FindTicketByID(ticketID);
        if (ticketToRetrieve != null)
        {
            return ticketToRetrieve;
        }
        else
        {
            Console.WriteLine("Ticket with ID " + ticketID + " not found.");
            return null;
        }
    }

     public List<TicketManagementAndTracking> GetAllOpenTickets()
    {
        List<TicketManagementAndTracking> openTickets = new List<TicketManagementAndTracking>();        
        foreach (TicketManagementAndTracking ticket in allTicketsList)
        {
            if (ticket.Status == "Open")
            {
                openTickets.Add(ticket);
            }
        }
        return openTickets;
    }

    public List<TicketManagementAndTracking> GetAssignedTickets(int employeeID)
    {
        List<TicketManagementAndTracking> assignedTickets = new List<TicketManagementAndTracking>();        
        foreach (TicketManagementAndTracking ticket in allTicketsList)
        {
            if (ticket.Status == "Assigned" && ticket.EmployeeID == employeeID)
            {
                assignedTickets.Add(ticket);
            }
        }
        return assignedTickets;
    }

    public void ManagePriority(int ticketID, string priority)
    {
        TicketManagementAndTracking ticketToUpdatePriority = FindTicketByID(ticketID);
        if (ticketToUpdatePriority != null)
        {
            ticketToUpdatePriority.Priority = priority;          
            Console.WriteLine("Priority of Ticket with ID " + ticketID + " updated to: " + priority);
        }
        else
        {
            Console.WriteLine("Ticket with ID " + ticketID + " not found.");
        }
    }

    private static int lastGeneratedTicketID = 0; 
    private int GenerateTicketID()
    {
        lastGeneratedTicketID++; 
        return lastGeneratedTicketID;
    }

    public TicketManagementAndTracking FindTicketByID(int ticketID)
    {
        foreach (TicketManagementAndTracking ticket in allTicketsList)
        {
            if (ticket.TicketID == ticketID)
            {
                return ticket; 
            }
        }
        return null;
    }
}
