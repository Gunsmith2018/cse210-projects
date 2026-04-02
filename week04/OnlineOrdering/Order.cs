public class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    // This function adds a product to the order list
    public void AddProduct(Product product)
    {
        _product.Add(product); // adds the product to the list
    }

    public Double GetTotalCost()
    {
        double total = 0;// variable for total cost
        foreach (Product product in _product) // adding up the total cost
        {
            total += product.GetPrice();
        }
        double shipping = _customer.LivesInUSA() ? 5 : 35; // this line is checking to see if the user lives in the USA or not. 
                                                            // If yes, the shipping will be 5 USD if no then 35 USD. 

        return total + shipping;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetfullAddress()}";
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach(Product product in _product)
        {
            label += $"{product.GetProduct()} ({product.GetID()})\n";
        }
        return label;
    }
}
