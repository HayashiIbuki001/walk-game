using UnityEngine;

public class ShopBackEventController : MonoBehaviour
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
        Debug.Log("”L‚Æ‘˜‹ö‚µ‚½D");
    }

    public void EventB()
    {
        Debug.Log("’m‚ç‚È‚¢l‚Æo‰ï‚Á‚½D");
    }

    public void EventC()
    {
        Debug.Log("‰J‚ª~‚Á‚Ä‚«‚½D");
    }
}
