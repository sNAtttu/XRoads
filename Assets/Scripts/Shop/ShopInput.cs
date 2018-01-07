using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInput : MonoBehaviour
{
    public Text FoodAmountText;

    private ShopInventoryManager inventory;

    private void Start()
    {
        inventory = GetComponent<ShopInventoryManager>();
    }

    public void IncreaseFoodAmount()
    {
        int currentAmount = int.Parse(FoodAmountText.text);
        currentAmount++;
        FoodAmountText.text = string.Format("{0}", currentAmount);
        inventory.ChangeFoodAmount(true);
    }
    public void DecreaseFoodAmount()
    {
        int currentAmount = int.Parse(FoodAmountText.text);
        currentAmount--;
        FoodAmountText.text = string.Format("{0}", currentAmount);
        inventory.ChangeFoodAmount(false);
    }
}
