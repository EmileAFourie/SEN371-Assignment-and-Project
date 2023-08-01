public class ClientDetail
{
    public int ClientID { get; set; }
    public string Name { get; set; }
    private string Address { get; set; }
    private string CellNo { get; set; }
    private string Email { get; set; }
    protected int ContractId { get; set; }
    protected string ClientType { get; set; }

    public Contract Contract { get; set; }

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

    public void UpdateContractDetails()
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

    public void PostToDb()
    {
        // Implementation to insert a new client into the database
    }
}
