using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPItem : Item
{
    public override void Use()
    {
        Debug.Log($"Using {itemName}: Increased MP");
    }
}
