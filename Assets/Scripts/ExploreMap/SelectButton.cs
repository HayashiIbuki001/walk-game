using UnityEngine;

public class SelectButton : MonoBehaviour
{
    public Inventory inventory;
    public ExploreMapData data;
    public ParkEventController parkEvents;

    public void OnClickButton()
    {
        GetItem();

        int result = DrawEvent();
        parkEvents.Execute(result);

        Debug.Log($"{data.MapName}ÇíTçıÇµÇΩÅBEvent : {result}");
    }

    private void GetItem()
    {
        int index = Random.Range(0, data.DropItems.Length);
        var item = data.DropItems[index];

        inventory.AddItem(item);
    }

    private int DrawEvent()
    {
        float rnd = Random.value;
        float sum = 0;

        for (int i = 0; i < data.eventTable.Length; i++)
        {
            sum += data.eventTable[i].probability;
            if (rnd <= sum) return i;
        }

        return -1;
    }
}
