using System;

public class CartService
{
    public Client _items = new Client();
    public int CountLength() // Code not needed
    {
        var lenght = _items._howmany;
        return lenght;
    }

    public void PlaceInCart(string[] productslist)
    {
        Products[] itemsincart = new Products[productslist.Length];
        for (int i = 0; i < productslist.Length; i++)
        {
            var ind = productslist[i];
            Products whatprod = new Products();
            itemsincart[i] = whatprod.GetProduct(ind);
        }

        Console.WriteLine(" ");
        Console.WriteLine("The following items were placed in Cart:");

        foreach (var item in itemsincart)
        {
            Console.WriteLine($"{item._name} for {item._price}");
        }

        Console.WriteLine(" ");
        Console.WriteLine("Do you want to confirm the order? Type 'Yes' to confirm and 'No' to remade");
        var confirm = Console.ReadLine();
        if (confirm == "Yes")
        {
            OrderService order = new OrderService();
            order.FormOrder(itemsincart);
        }
        else if (confirm == "No")
        {
            var client = new Client();
            client.CreateShoppingList();
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}
