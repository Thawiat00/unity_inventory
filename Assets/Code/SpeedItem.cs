using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class SpeedItem : Item
{
    public override void Use()
    {
        Debug.Log($"Using {itemName}: Increased Speed");
    }
}
