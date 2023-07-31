using System;

public class Contract
{
    public int ContractID { get; set; }
    public string ContractName { get; set; }
    private string StartDate { get; set; }
    private string EndDate { get; set; }
    private string Description { get; set; }
    private double Price { get; set; }
    protected bool Availablilty { get; set; }
    public int ClientID { get; set; }

    public void ModifyContract(string newName, string newDescription, double newFee)
    {
        //Implementation to modify a existing contract
    }
    public void AddContract(string newName, string newDescription, double newFee)
    {
        //Implementation to add a new contract
    }
    public void ViewActiveContracts()
    {
        //Implementation to view the currently active contracts the client has
    }
    public void RenewContract()
    {
        //Implementation to renew the currently active contract the client has
    }
    public void ViewContract()
    {
        //Implementation to view the details of the avalible contracts
    }
    public void DeleteContract()
    {
        //Implementation to remove a contract
    }
    public void ContractAvailability()
    {
        //Implementation to see what contacts are currently being offered
    }
}
