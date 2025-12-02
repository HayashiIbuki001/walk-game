using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<ItemData> items = new();

    public void AddItem(ItemData item)
    {
        items.Add(item);
        Debug.Log($"{item.itemName}‚ðŽè‚É“ü‚ê‚½");
    }
}