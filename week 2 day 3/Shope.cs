public class Shop : Product
{
    List <Product> products = new List<Product>();
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
}