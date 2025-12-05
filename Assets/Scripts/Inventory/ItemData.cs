using UnityEngine;

[CreateAssetMenu(menuName = "Walk Game/Item")]
public class ItemData : ScriptableObject
{
    public string itemName; // –¼‘O
    public string desc;     // à–¾
    public ItemType type;   // í—Ş
}

public enum ItemType
{
    Heal,
    Material,
    Item
}
