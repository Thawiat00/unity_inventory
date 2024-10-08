using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Item Pickup
public class ItemPickup : MonoBehaviour
{
    public Item item; // Reference to the Item
    private InventorySystem inventory;


    private void Start()
    {
        inventory = FindObjectOfType<InventorySystem>();
        if (inventory == null)
        {
            Debug.LogError("InventorySystem not found in the scene!");
        }
    }

    // This method will be called when the pickup button is clicked
    public void OnPickupButtonClick()
    {
        if (item == null)
        {
            Debug.LogError("Item is null!");
            return;
        }

        Debug.Log($"Picking up item: {item.itemName}");
        inventory.AddItem(item);

        // ????????????? object ??????????
        gameObject.SetActive(false);
    }
}