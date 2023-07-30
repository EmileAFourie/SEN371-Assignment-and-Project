using System;
using System.Collections.Generic;

public class ServiceCatalog
{
    public int ClientID { get; set; }
    public string ServiceOffered { get; set; }
    public string Contracts { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool ServiceAvailability { get; set; }

    private List<ServiceCatalog> services = new List<ServiceCatalog>();

    public void AddService(ServiceCatalog newService)
    {
        services.Add(newService);
        Console.WriteLine("Service added successfully!");
    }

    public void UpdateService(int clientID, string updatedServiceOffered, string updatedContracts, string updatedDescription, decimal updatedPrice, bool updatedServiceAvailability)
    {
        var service = services.Find(s => s.ClientID == clientID);
        if (service != null)
        {
            service.ServiceOffered = updatedServiceOffered;
            service.Contracts = updatedContracts;
            service.Description = updatedDescription;
            service.Price = updatedPrice;
            service.ServiceAvailability = updatedServiceAvailability;
            Console.WriteLine("Service updated successfully!");
        }
        else
        {
            Console.WriteLine($"Service for ClientID {clientID} not found.");
        }
    }

    public void DeleteService(int clientID)
    {
        var service = services.Find(s => s.ClientID == clientID);
        if (service != null)
        {
            services.Remove(service);
            Console.WriteLine("Service deleted successfully!");
        }
        else
        {
            Console.WriteLine($"Service for ClientID {clientID} not found.");
        }
    }

    public void CheckServiceAvailability(int clientID)
    {
        var service = services.Find(s => s.ClientID == clientID);
        if (service != null)
        {
            Console.WriteLine($"Service for ClientID {clientID} is {(service.ServiceAvailability ? "available" : "not available")}.");
        }
        else
        {
            Console.WriteLine($"Service for ClientID {clientID} not found.");
        }
    }
}
