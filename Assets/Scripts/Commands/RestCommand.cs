using UnityEngine;

public class RestCommand : MonoBehaviour
{
    private float[] weights = { 0.5f, 0.3f, 0.2f };
    float r = 0;
    float sum = 0;

    public void ClickRestButton()
    {
        sum = 0f;
        r = Random.value;

        for (int i = 0; i < weights.Length; i++)
        {
            sum += weights[i];
            if (r < sum)
            {
                if (i == 0) EventA();
                else if (i == 1) EventB();
                else if (i == 2) EventC();
                break;
            }
        }
    }

    private void EventA()
    {
        Debug.Log($"EventA");
    }

    private void EventB()
    {
        Debug.Log($"EventB");
    }

    private void EventC()
    {
        Debug.Log($"EventC");
    }
}
