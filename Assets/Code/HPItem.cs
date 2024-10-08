using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Concrete Item classes
public class HPItem : Item
{
    public override void Use()
    {
        Debug.Log($"Using {itemName}: Increased HP");
    }
}