using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public GameObject slotPrefub;
    public Transform slotPanel;

    public GameObject inventoryUI;

    private bool isOpen;

    public void ClickBagButton()
    {
        isOpen = !isOpen;
        inventoryUI.SetActive(isOpen);

        if (isOpen)
            UpdateUI();
    }

    public void UpdateUI()
    {
        foreach (Transform child in slotPanel)
            Destroy(child.gameObject);

        foreach (var item in  inventory.items)
        {
            GameObject slot = Instantiate(slotPrefub, slotPanel);
            slot.GetComponent<TMP_Text>().text = $"{item.data.itemName} Å~{item.count}";
        }
    }
}
