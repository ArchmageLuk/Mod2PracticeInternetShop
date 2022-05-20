using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Client
{
    public int _howmany;

    public Client()
    {
        _howmany = new Random().Next(3, 11);
    }

    public void CreateShoppingList()
    {
        Console.WriteLine($"Client said: 'I want to buy {_howmany} items:");
        int[] wannabuynums = new int[_howmany];
        for (int i = 0; i < _howmany; i++)
        {
                wannabuynums[i] = new Random().Next(1, 11);
        }

        Array.Sort(wannabuynums);

        string[] wannabuyitems = new string[_howmany];
        for (int i = 0; i < wannabuynums.Length; i++)
        {
            Products shopstand = new Products();
            wannabuyitems[i] = shopstand._productsinshop[wannabuynums[i]];
        }

        foreach (string i in wannabuyitems)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(" ");

        CartService initialize = new CartService();
        initialize.PlaceInCart(wannabuynums);
    }
}
