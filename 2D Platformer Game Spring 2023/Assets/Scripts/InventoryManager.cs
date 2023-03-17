using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public int inventory = 0;
    public TextMeshProUGUI inventoryText;

    public void AddToInventory()
    {
        inventory ++;
        UpdateInventoryText();
    }

    public void UpdateInventoryText()
    {
        inventoryText.text = "Coins: " + inventory;
    }
}
