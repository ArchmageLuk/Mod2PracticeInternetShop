using System;

public class OrderService
{
    public void FormOrder(Products[] array)
    {
        string[] receipt = new string[array.Length + 3];
        int ordercode = 00001;
        string title = $"Here is your Order No.{ordercode}";
        string introduction = "You ordered:";
        int totalprice = 0;

        receipt[0] = title;
        receipt[1] = introduction;

        foreach (var product in array)
        {
            var ind = Array.IndexOf(array, product);

            string receiptline = $"{product._name} ------- {product._price}";
            receipt[ind + 2] = receiptline;
            totalprice = totalprice + product._price;
        }

        var resultprice = $"Total price of your order: {totalprice}";
        receipt[array.Length + 2] = resultprice;

        File.WriteAllLines("receipt.txt", receipt);

        MessageService message = new MessageService();
        message.MessageClient(array);
    }
}