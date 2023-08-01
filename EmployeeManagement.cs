using System;
using System.Collections.Generic;

public class EmployeeManagement
{
    private int empID;
    private string name;
    private string email;
    private string position;
    private int age;
    private string performance;
    private List<int> ticketIDs;

    private static List<EmployeeManagement> employeesList = new List<EmployeeManagement>();

    public int EmpID { get => empID; set => empID = value; }
    public string Name { get => name; set => name = value; }
    public string Email { get => email; set => email = value; }
    public string Position { get => position; set => position = value; }
    public int Age { get => age; set => age = value; }
    public string Performance { get => performance; set => performance = value; }
    public List<int> TicketIDs { get => ticketIDs; set => ticketIDs = value; }

    public EmployeeManagement(int empID, string name, string email, string position, int age, string performance)
    {
        this.empID = empID;
        this.name = name;
        this.email = email;
        this.position = position;
        this.age = age;
        this.performance = performance;
        this.ticketIDs = new List<int>();
    }

    public void ViewEmployee(int empID)
    {
       //View details of an employee by their EmpID.
    }
    
    public List<EmployeeManagement> ViewAllEmployees()
    {
       //View details of all employees in the company.
    }
    
    public void AddEmployee(EmployeeManagement newEmployee)
    {
        // Add a new employee to the employee list.
    }
    
    public void DeleteEmployee(int empID)
    {
        // Delete an employee from the employee list by their EmpID.
    }
    
    public void EditEmployee(int empID, EmployeeManagement updatedEmployee)
    {
        // Edit the details of an existing employee by their EmpID.
    }
    
    public void AssignTicket(int ticketID)
    {
        // Assign a ticket to an employee by its TicketID.
    }
    
    public List<int> ViewActiveJobs()
    {
        // View a list of TicketIDs for active jobs related to an employee.        
    }

    public void PerformanceReport(){
        // Generate a performance report based on employees.
    }
}
