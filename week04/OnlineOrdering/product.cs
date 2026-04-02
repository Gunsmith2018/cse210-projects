public class Product
{
    private string _product;
    private string _id;
    private double _price;

    public Product(string product, string id, double price)
    {
        _product = product;
        _id = id;
        _price = price;
    }

    public string GetProduct()
    {
        return _product;
    }

    public string GetID()
    {
        return _id;
    }
    
    public Double GetPrice()
    {
        return _price;
    }







}