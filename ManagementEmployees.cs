using System;
using System.Collections.Generic;

public class EmployeeManagement
{
    public int EmpID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
    public int Age { get; set; }
    public string Performance { get; set; }
    public int TicketID { get; set; }

    private List<EmployeeManagement> employees = new List<EmployeeManagement>();

    public void ViewEmployees()
    {
        Console.WriteLine("List of Employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"EmpID: {employee.EmpID}, Name: {employee.Name}, Email: {employee.Email}, Position: {employee.Position}");
        }
    }

    public void DeleteEmployee(int empID)
    {
        var employee = employees.Find(e => e.EmpID == empID);
        if (employee != null)
        {
            employees.Remove(employee);
            Console.WriteLine($"Employee with EmpID {empID} has been deleted.");
        }
        else
        {
            Console.WriteLine($"Employee with EmpID {empID} not found.");
        }
    }

    public void EditEmployee(int empID, string newName, string newEmail, string newPosition, int newAge, string newPerformance)
    {
        var employee = employees.Find(e => e.EmpID == empID);
        if (employee != null)
        {
            employee.Name = newName;
            employee.Email = newEmail;
            employee.Position = newPosition;
            employee.Age = newAge;
            employee.Performance = newPerformance;
            Console.WriteLine($"Employee with EmpID {empID} has been updated.");
        }
        else
        {
            Console.WriteLine($"Employee with EmpID {empID} not found.");
        }
    }

    public void AssignTicket(int empID, int ticketID)
    {
        var employee = employees.Find(e => e.EmpID == empID);
        if (employee != null)
        {
            employee.TicketID = ticketID;
            Console.WriteLine($"Ticket with TicketID {ticketID} has been assigned to Employee with EmpID {empID}.");
        }
        else
        {
            Console.WriteLine($"Employee with EmpID {empID} not found.");
        }
    }

    public void ViewActiveJobs()
    {
        Console.WriteLine("List of Active Jobs:");
        foreach (var employee in employees)
        {
            if (employee.TicketID != 0)
            {
                Console.WriteLine($"EmpID: {employee.EmpID}, TicketID: {employee.TicketID}");
            }
        }
    }
}
