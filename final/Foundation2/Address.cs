public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    // this code woud help get the full adress as a string 
    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
    }

    // Method to check if adress is in USA
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }
}