public class Product
{
    string _name;
    string _productID;
    float _price;
    int _quantity;

    public Product(string name, string productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public float TotalCost()
    {
        return 0;
    }
}