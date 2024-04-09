using System.Net.Sockets;

public class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool inUSA()
    {
        return false;
    }
}