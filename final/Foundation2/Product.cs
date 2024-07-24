public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Getter for name 
    public string GetName()
    {
        return name;
    }

    //Getter for productId
    public string GetProductId()
    {
        return productId;
    }

    //Method to calculate total cost of the product 
    public decimal GetTotalCost()
    { 
        return price * quantity;
    }
}   
