using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public ItemData[] dropItems; // ランダムで取得する候補
    public Inventory inventory;  // 所持管理スクリプト

    public void Drop()
    {
        if (dropItems.Length == 0) return;

        int r = Random.Range(0, dropItems.Length);
        inventory.AddItem(dropItems[r]);
    }
}
