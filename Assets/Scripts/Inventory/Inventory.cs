using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public List<InventoryItem> items = new();

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject); // •¡”¶¬–hŽ~
    }

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

    public void RemoveRandomItem(out string removedItemName)
    {
        removedItemName = null;
        if (items.Count == 0)
        {
            return;
        }

        int index = Random.Range(0, items.Count);
        InventoryItem selected = items[index];

        selected.count--;
        removedItemName = selected.data.itemName;

        if (selected.count <= 0)
        {
            items.RemoveAt(index);
        }

        Debug.Log($"{selected.data.itemName}‚ð1‚ÂŽ¸‚Á‚½BŽc‚è{selected.count}");
    }
}