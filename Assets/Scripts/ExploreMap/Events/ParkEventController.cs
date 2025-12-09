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

    public void EventA()
    {
        Debug.Log("”L‚Æ‘˜‹ö‚µ‚½");
    }

    public void EventB()
    {
        Debug.Log("’m‚ç‚È‚¢l‚Æo‰ï‚Á‚½");
    }

    public void EventC()
    {
        Debug.Log("‰J‚ª~‚Á‚Ä‚«‚½");
    }
}
