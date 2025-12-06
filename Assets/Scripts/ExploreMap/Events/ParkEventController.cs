using UnityEngine;

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

    private void EventA()
    {
        Debug.Log("”L‚Æ‘˜‹ö‚µ‚½");
    }

    private void EventB()
    {
        Debug.Log("");
    }

    private void EventC()
    {

    }
}
