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
        EmployeeManagement employee = FindEmployeeByID(empID);

        if (employee != null)
        {
            Console.WriteLine("Employee ID: " + employee.EmpID);
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Email: " + employee.Email);
            Console.WriteLine("Position: " + employee.Position);
            Console.WriteLine("Age: " + employee.Age);
            Console.WriteLine("Performance: " + employee.Performance);

            if (employee.TicketID.Count > 0)
            {
                Console.WriteLine("Assigned Tickets:");
                foreach (int ticketID in employee.TicketID)
                {
                    Console.WriteLine("- Ticket ID: " + ticketID);
                }
            }
            else
            {
                Console.WriteLine("No tickets assigned.");
            }
        }
        else
        {
            Console.WriteLine("Employee with ID " + empID + " not found.");
        }
    }

     public List<EmployeeManagement> ViewAllEmployees()
    {
        List<EmployeeManagement> allEmployees = new List<EmployeeManagement>();

        foreach (EmployeeManagement employee in employeesList)
        {
            Console.WriteLine("Employee ID: " + employee.EmpID);
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Email: " + employee.Email);
            Console.WriteLine("Position: " + employee.Position);
            Console.WriteLine("Age: " + employee.Age);
            Console.WriteLine("Performance: " + employee.Performance);

            if (employee.TicketID.Count > 0)
            {
                Console.WriteLine("Assigned Tickets:");
                foreach (int ticketID in employee.TicketID)
                {
                    Console.WriteLine("- Ticket ID: " + ticketID);
                }
            }
            else
            {
                Console.WriteLine("No tickets assigned.");
            }

            allEmployees.Add(employee);

            Console.WriteLine("---------------------------");
        }

        return allEmployees;
    }

    public void AddEmployee(EmployeeManagement newEmployee)
    {
        EmployeeManagement existingEmployee = FindEmployeeByID(newEmployee.EmpID);
        if (existingEmployee != null)
        {
            Console.WriteLine("Employee with ID " + newEmployee.EmpID + " already exists.");
            return; 
        }

        employeesList.Add(newEmployee);
        Console.WriteLine("Employee with ID " + newEmployee.EmpID + " added successfully.");
    }

   public void DeleteEmployee(int empID)
    {
        EmployeeManagement employeeToDelete = FindEmployeeByID(empID);

        if (employeeToDelete != null)
        {
            employeesList.Remove(employeeToDelete);
            Console.WriteLine("Employee with ID " + empID + " deleted successfully.");
        }
        else
        {
            Console.WriteLine("Employee with ID " + empID + " not found.");
        }
    }

    public void EditEmployee(int empID, EmployeeManagement updatedEmployee)
    {
        EmployeeManagement employeeToEdit = FindEmployeeByID(empID);

        if (employeeToEdit != null)
        {
            employeeToEdit.Name = updatedEmployee.Name;
            employeeToEdit.Email = updatedEmployee.Email;
            employeeToEdit.Position = updatedEmployee.Position;
            employeeToEdit.Age = updatedEmployee.Age;
            employeeToEdit.Performance = updatedEmployee.Performance;

            Console.WriteLine("Employee with ID " + empID + " updated successfully.");
        }
        else
        {
            Console.WriteLine("Employee with ID " + empID + " not found.");
        }
    }

    public void AssignTicket(int ticketID)
    {
        TicketID.Add(ticketID);
        Console.WriteLine("Ticket with ID " + ticketID + " assigned successfully to employee with ID " + EmpID);
    }

    public List<int> ViewActiveJobs()
    {
        List<int> activeJobs = new List<int>();

        foreach (int ticketID in TicketID)
        {
            if (Ticket.IsActive(ticketID))
            {
                activeJobs.Add(ticketID);
            }
        }

        return activeJobs;
    }
}
