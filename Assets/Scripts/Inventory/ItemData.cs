using UnityEngine;

[CreateAssetMenu(menuName = "WalkGame/Item")]
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
