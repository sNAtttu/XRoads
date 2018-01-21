using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInput : MonoBehaviour
{
    public Text FoodAmountText;

    private ShopInventoryManager _inventory;

    private void Start()
    {
        _inventory = GetComponent<ShopInventoryManager>();
    }

    public void IncreaseFoodAmount()
    {
        int currentAmount = int.Parse(FoodAmountText.text);
        currentAmount++;
        FoodAmountText.text = string.Format("{0}", currentAmount);
        _inventory.ChangeFoodAmount(true);
    }
    public void DecreaseFoodAmount()
    {
        int currentAmount = int.Parse(FoodAmountText.text);
        currentAmount--;
        FoodAmountText.text = string.Format("{0}", currentAmount);
        _inventory.ChangeFoodAmount(false);
    }
    public void RepairAll()
    {
        Debug.Log("Repair all items");
    }
    public void BuyHasteBuff()
    {
        Debug.Log("Haste");
    }
    public void ClearSelection()
    {
       GetComponent<PlayMakerFSM>().SendEvent("ClearSelection");
    }
}
