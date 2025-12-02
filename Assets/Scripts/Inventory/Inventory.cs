using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> items = new();

    public void AddItem(ItemData item)
    {
        var exist = items.Find(i => i.data == item);

        if (exist != null)
        {
            exist.count++;
        }
        else
        {
            items.Add(new InventoryItem(item));
        }

        Debug.Log($"{item.itemName}‚ðŽè‚É“ü‚ê‚½BŒ»Ý{items.Find(i => i.data == item).count}ŒÂ");
    }
}