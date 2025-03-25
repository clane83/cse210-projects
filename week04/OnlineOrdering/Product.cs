using System;

public class Product{
    
    /*
    Contains the name, product id, price, and quantity of each product.
    The total cost of this product is computed by multiplying the price 
    per unit and the quantity. (If the price per unit was $3 and they bought 
    5 of them, the product total cost would be $15.)
    */
    private string _productName = "";
    private int _productId = 0;
    private double _price = 0.00;
    private int _quantity = 0;
    private double _totalPrice;

    public Product(string productName, int id, double price, int quantity){
        
        _productName = productName;
        _productId = id;
        _price = price;
        _quantity = quantity;

    }

    public double GetProductTotal(){
        _totalPrice = _price * _quantity;
        return _totalPrice;
    }

    public string GetProductText(){
        return $"{_productName} - {_productId} - ordered:{_quantity}";
    }

}