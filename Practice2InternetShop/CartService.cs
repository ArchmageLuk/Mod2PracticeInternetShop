using System;

public class CartService
{
    public Client _item = new Client();
    _howmany =


    public Products[] _itemsincart = new Products[];
    public void PlaceInCart(int[] productslist)
    {
        foreach (var product in productslist)
        {
            var ind = Array.IndexOf(productslist, product);
            if (product == 1)
            {
                Pineapple item = new Pineapple();
                _itemsincart[ind] = item;
            }
        }
    }
}