using System;

public class ClientDetail
{
    public int ClientID { get; set; }
    public string Name { get; set; }
    private string Address { get; set; }
    private string CellNo { get; set; }
    private string Email { get; set; }
    protected int ContractId { get; set; }
    protected string ClientType { get; set; }

    public ClientDetail(int ClientID, string Name, string Address, string CellNo, string Email, string ClientType, string ContractId){
        this.ClientID = ClientID;
        this.Name = Name;
        this.Address = Address;
        this.CellNo = CellNo;
        this.Email = Email;
        this.ClientType = ClientType;
        this.ContractId = ContractId;
    }

    public void UpdateContractDetials()
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
        //Implementation to insert a new client into the database
    }
}
