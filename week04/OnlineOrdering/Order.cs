using System;

public class Order{
    
  /*  Order
    Contains a list of products and a customer. Can calculate the total cost 
    of the order. Can return a string for the packing label. Can return a string 
    for the shipping label.
    The total price is calculated as the sum of the total cost of each product plus 
    a one-time shipping cost.
    This company is based in the USA. If the customer lives in the USA, then the 
    shipping cost is $5. If the customer does not live in the USA, then the shipping 
    cost is $35.
    A packing label should list the name and product id of each product in the order.
    A shipping label should list the name and address of the customer*/

  private List<Product> _productsList = new List<Product>();
  private Customer _customer;
  private double _orderSubTotal = 0.00;
  private double _oderTotal = 0.00;
  private int _shippingTotal = 0;

  public Order(Customer customer, params Product[] products){
    _productsList = new List<Product>(products);
    _customer = customer;
  }

  public int GetShippingCost(){
    if (_customer.IsInUSA())
    {
      _shippingTotal = 5;
    } else {
      _shippingTotal = 35;
    }
    return _shippingTotal;
  }

  public double GetOrderSubTotal(){
    foreach (Product product in _productsList){
      _orderSubTotal += product.GetProductTotal();
    }
    return _orderSubTotal;
  }

  public double GetOrderTotal(){
    _oderTotal = _orderSubTotal + _shippingTotal;
    return _oderTotal;
  }


}