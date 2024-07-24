public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    //Getter for name 
    public string GetName()
    {
        return name;
    }
    //Method to check if customer lives in USA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    // Method to get the address 
    public Address GetAddress()
    {
        return address;
    }
}