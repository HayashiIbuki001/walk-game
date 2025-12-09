using UnityEngine;

public class SelectButton : MonoBehaviour
{
    public Inventory inventory;
    public ExploreMapData data;

    [SerializeField] private int locationIndex;

    public void OnClickButton()
    {
        GetItem();

        int eventIndex = Random.Range(0, 4);
        EventManager.Instance.RunEvent(locationIndex, eventIndex);
    }

    private void GetItem()
    {
        int index = Random.Range(0, data.DropItems.Length);
        var item = data.DropItems[index];

        inventory.AddItem(item);
    }
}
