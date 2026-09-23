public class Product
{
   public string? name{get; set;}
   public double price {get; set;}
    public Product(){}
   public Product (string n, double pr)
    {
        name = n;
        price = pr;
    }
}