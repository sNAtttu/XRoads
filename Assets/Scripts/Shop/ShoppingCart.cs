using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCart
{
    public ShoppingCart()
    {
        FoodAmount = 0;
        SelectedWeapon = null;
        SelectedArmor = null;
        Total = 0;
    }
    public int FoodAmount;
    public Weapon SelectedWeapon;
    public Armor SelectedArmor;
    public int Total;

    public override string ToString()
    {
        return string.Format("Food: {0}, Weapon: {1}, Armor: {2}, Total: {3}", FoodAmount, SelectedWeapon, SelectedArmor, Total);
    }

}

