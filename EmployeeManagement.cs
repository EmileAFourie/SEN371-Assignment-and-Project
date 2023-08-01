using System;
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

    public int EmpID1 { get => EmpID; set => EmpID = value; }
    public string Name1 { get => Name; set => Name = value; }
    public string Email1 { get => Email; set => Email = value; }
    public string Position1 { get => Position; set => Position = value; }
    public int Age1 { get => Age; set => Age = value; }
    public string Performance1 { get => Performance; set => Performance = value; }
    public List<int> TicketID1 { get => TicketID; set => TicketID = value; }

    public EmployeeManagement(int empID, string name, string email, string position, int age, string performance)
    {
        this.EmpID1 = empID;
        this.Name1 = name;
        this.Email1 = email;
        this.Position1 = position;
        this.Age1 = age;
        this.Performance1 = performance;
        this.TicketID1 = new List<int>();
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
