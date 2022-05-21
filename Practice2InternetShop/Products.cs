using System;

public class Products
{
    public int _article;
    public string? _name;
    public int _price;

    public string[] _productsinshop = new string[]
    {
        "Nothing",
        "Apple",
        "Banana",
        "Cake",
        "Carrot",
        "Kiwi",
        "Pepper",
        "Pineapple",
        "Salt",
        "Sugar",
        "Tomato"
    };

    public Products()
    {
    }

    public Products GetProduct(string type)
    {
        Products productdata = new Products();
        if (type == "Apple")
        {
            Apple item = new Apple();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Banana")
        {
            Banana item = new Banana();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Cake")
        {
            Cake item = new Cake();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Carrot")
        {
            Carrot item = new Carrot();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Kiwi")
        {
            Kiwi item = new Kiwi();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Pepper")
        {
            Pepper item = new Pepper();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Pineapple")
        {
            Pineapple item = new Pineapple();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Salt")
        {
            Salt item = new Salt();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Sugar")
        {
            Sugar item = new Sugar();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        if (type == "Tomato")
        {
            Tomato item = new Tomato();
            productdata._article = item._article;
            productdata._name = item._name;
            productdata._price = item._price;
        }

        return productdata;
    }
}