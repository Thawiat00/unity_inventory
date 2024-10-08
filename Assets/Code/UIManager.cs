using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// UI Manager
public class UIManager : MonoBehaviour
{
    public InventorySystem inventory;
    public GameObject inventoryPanel;
    public GameObject itemSlotPrefab;
    public Transform itemsParent;

    private void Start()
    {
        inventory.onInventoryChanged += UpdateInventoryUI;
        inventoryPanel.SetActive(false);
    }

    public void ToggleInventory()
    {
        inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        if (inventoryPanel.activeSelf)
        {
            UpdateInventoryUI();
        }
    }

    private void UpdateInventoryUI()
    {
        foreach (Transform child in itemsParent)
        {
            Destroy(child.gameObject);
        }

        foreach (var item in inventory.items)
        {
            GameObject slot = Instantiate(itemSlotPrefab, itemsParent);
            Image icon = slot.transform.Find("Icon").GetComponent<Image>();
            icon.sprite = item.icon;

            Button useButton = slot.transform.Find("UseButton").GetComponent<Button>();
            useButton.onClick.AddListener(() => inventory.UseItem(item));

            Button dropButton = slot.transform.Find("DropButton").GetComponent<Button>();
            dropButton.onClick.AddListener(() => inventory.RemoveItem(item));
        }
    }

}