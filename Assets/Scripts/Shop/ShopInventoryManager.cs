using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventoryManager : MonoBehaviour
{
    public ShoppingCart ShoppingCart;

    private void Start()
    {
        ShoppingCart = new ShoppingCart();
    }

    public void ChangeFoodAmount(bool add)
    {
        if (add)
        {
            ShoppingCart.FoodAmount++;
        }
        else
        {
            ShoppingCart.FoodAmount--;
        }
        Debug.Log(ShoppingCart);
    }

}
