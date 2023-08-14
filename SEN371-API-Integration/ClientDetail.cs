using System;
// ###############
// ###############
// ###############

// this is now the base class

// ###############
// ###############
// ###############
// ###############
public class ClientDetail
{
    public int ClientID { get; set; }
    public string Name { get; set; }
    private string Address { get; set; }
    private string CellNo { get; set; }
    private string Email { get; set; }
    protected int ContractId { get; set; }
    protected string ClientType { get; set; }
    
    public Contract Contract { get; set; } // This shows that each client can only have one contract.

    public ClientDetail(int clientID, string name, string address, string cellNo, string email, string clientType, int contractId)
    {
        ClientID = clientID;
        Name = name;
        Address = address;
        CellNo = cellNo;
        Email = email;
        ClientType = clientType;
        ContractId = contractId;
    }

    public void UpdateContactDetails()
    {
        // Implementation to modify the client details in the database
    }

    public void AssignContract()
    {
        // Implementation to assign a service contract to the client
    }

    public ClientDetail GetClientDetails()
    {
        // Implementation to return the client details        
    }

    public ClientDetail(int ClientID, string Name, string Address, string CellNo, string Email, string ClientType, string ContractId){
        this.ClientID = ClientID;
        this.Name = Name;
        this.Address = Address;
        this.CellNo = CellNo;
        this.Email = Email;
        this.ClientType = ClientType;
        this.ContractId = ContractId;
    }

    public void UpdateContractDetails()
    {
        //Implemntation to modify the client detials in the database
    }
    public void AssignContract()
    {
        //Implementation to assign a service contract to the client
    }
    public void GetClientDetails()
    {
        //Implementation to return the client details
    }
    public void PostToDb()
    {
        // Implementation to insert a new client into the database
    }
}
