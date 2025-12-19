using UnityEngine;
using static UnityEditor.Progress;

public class ParkEventController : MonoBehaviour
{
    public void Execute(int index)
    {
        switch (index)
        { 
            case 0: EventA(); break;
            case 1: EventB(); break;
            case 2: EventC(); break;
            default: Debug.Log("No Event"); break;
        }
    }

    public void EventA()
    {
        ExploreText.Instance.Enqueue($"wao! neko!");
    }

    public void EventB()
    {
        ExploreText.Instance.Enqueue("who are you?");
    }

    public void EventC()
    {
        ExploreText.Instance.Enqueue("oh! rain!");
    }
}
