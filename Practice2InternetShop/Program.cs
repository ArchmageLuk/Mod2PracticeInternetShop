using System;

public class Program
{
    private static void Main()
    {
        Console.WriteLine("Client opened a store.");
        var client = new Client();
        client.CreateShoppingList();
    }
}
