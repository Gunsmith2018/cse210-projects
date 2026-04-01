public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string Street, string City, string State, string Country)
    {
        _street = Street;
        _city = City;
        _state = State;
        _country = Country;
    }

    public bool IsInUSA()
    {
        if (_country.ToLower() == "united states")
        {
            return true; // this will be for 5 USD Shipping
        }
        else
        {
            return false; // this will be fore 35 USD shipping
        }
    }

public string GetfullAddress()
    {
        return $"{_street} {_city} {_state} {_country}";
    }

}