using System;

public class MessageService
{
   public void MessageClient(Products[] array)
    {
        Console.WriteLine(" ");
        int ordercode = 00001;
        Console.WriteLine($"Congratulations! You order {ordercode} was succesful!");
        Console.WriteLine("You ordered:");

        int totalprice = 0;
        foreach (var product in array)
        {
            Console.WriteLine($"{product._name} for {product._price}");
            totalprice = totalprice + product._price;
        }

        Console.WriteLine($"For a total price of {totalprice}");
        Console.WriteLine("Thank you for visit!");
    }
}