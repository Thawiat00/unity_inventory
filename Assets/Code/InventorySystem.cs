using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inventory System
public class InventorySystem : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public int maxItems = 10;

    // Observer pattern
    public delegate void OnInventoryChanged();
    public event OnInventoryChanged onInventoryChanged;




    public void AddItem(Item item)
    {
        if (item == null)
        {
            Debug.LogError("Cannot add null item to inventory!");
            return; // ???????????????????????? null
        }

        Debug.Log($"Adding item: {item.itemName}");

        if (items.Count < maxItems)
        {
            items.Add(item);
            item.gameObject.SetActive(false);
            onInventoryChanged?.Invoke();
        }
        else
        {
            Debug.Log("Inventory is full!");
        }
    }


    public void RemoveItem(Item item)
    {
        items.Remove(item);
        Destroy(item.gameObject);
        onInventoryChanged?.Invoke();
    }

    public void UseItem(Item item)
    {
        item.Use();
    }
}
