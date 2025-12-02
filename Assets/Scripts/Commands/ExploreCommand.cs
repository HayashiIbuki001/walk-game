using UnityEngine;

public class ExploreCommand : MonoBehaviour
{
    public ItemDrop itemDrop;

    public void ClickExploreButton()
    {
        itemDrop.Drop();
    }
}
