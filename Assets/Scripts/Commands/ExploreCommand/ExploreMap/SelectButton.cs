using UnityEngine;

public class SelectButton : MonoBehaviour
{
    [SerializeField] private GameObject ExploreCanvas;

    public Inventory inventory;
    public ExploreMapData data;

    [SerializeField] private int locationIndex;

    public void OnClickButton()
    {
        int dropItemCount = Random.Range(1, 3);

        for (int i = 0; i < dropItemCount; i++)
        {
            GetItem();
        }

        int eventIndex = Random.Range(0, 4);
        EventManager.Instance.RunEvent(locationIndex, eventIndex);

        ExploreCanvas.SetActive(false);
    }

    private void GetItem()
    {
        int index = Random.Range(0, data.DropItems.Length);
        var item = data.DropItems[index];

        inventory.AddItem(item);

        TextQueueController.Instance.Enqueue($"{item.itemName}‚ðŒ©‚Â‚¯‚½B");
    }
}
