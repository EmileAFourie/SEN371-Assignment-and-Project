public class EmployeeManagement
{
    private int EmpID;
    private string Name;
    private string Email;
    private string Position;
    private int Age;
    private string Performance;
    private List<int> TicketID; 

    private static List<EmployeeManagement> employeesList = new List<EmployeeManagement>();

    
    public EmployeeManagement(int empID, string name, string email, string position, int age, string performance)
    {
        this.EmpID = empID;
        this.Name = name;
        this.Email = email;
        this.Position = position;
        this.Age = age;
        this.Performance = performance;
        this.TicketID = new List<int>();
    }

    
    public void ViewEmployee(int empID)
    {
        
    }

     public List<EmployeeManagement> ViewAllEmployees()
    {
       
    }

    public void AddEmployee(EmployeeManagement newEmployee)
    {
       
    }

   public void DeleteEmployee(int empID)
    {
        
    }

    public void EditEmployee(int empID, EmployeeManagement updatedEmployee)
    {
       
    }

    public void AssignTicket(int ticketID)
    {
       
    }

    public List<int> ViewActiveJobs()
    {
       
    }
}
