using UnityEngine;

public class SelectButton : MonoBehaviour
{
    public Inventory inventory;
    public ExploreMapData data;

    public void OnClickButton()
    {
        string result = DrawEvent();

        GetItem();

        Debug.Log($"{data.MapName}‚ğ’Tõ‚µ‚½BEvent : {result}");
    }

    string DrawEvent()
    {
        float rnd = Random.value;
        float sum = 0;

        foreach (var ev in data.eventTable)
        {
            sum += ev.probability;
            if (rnd <= sum) return ev.eventName;
        }

        return "NoEvent";
    }

    private void GetItem()
    {
        int index = Random.Range(0, data.DropItems.Length);
        var item = data.DropItems[index];

        inventory.AddItem(item);
    }
}
