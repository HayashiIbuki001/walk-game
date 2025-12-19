using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public UnityEvent[] parkEvents; // 公園
    public UnityEvent[] alleyEvents; // 路地裏
    public UnityEvent[] buildingEvents; // 建物
    public UnityEvent[] shopBackEvents; // 店の裏

    /// <summary> イベント実行 </summary>
    /// <param name="locationIndex">場所を示すIndex</param>
    /// <param name="eventIndex">イベントの種類を示すIndex</param>
    public void RunEvent(int locationIndex, int eventIndex)
    {
        var table = GetEventTable(locationIndex);
        if (table == null || eventIndex < 0 || eventIndex >= table.Length)
        {
            Debug.Log("No Event");
            return;
        }
        table[eventIndex]?.Invoke();
    }

    private UnityEvent[] GetEventTable(int locationIndex)
    {
        switch (locationIndex)
        {
            case 0: return parkEvents;
            case 1: return alleyEvents;
            case 2: return buildingEvents;
            case 3: return shopBackEvents;
        }
        return null;
    }
}
