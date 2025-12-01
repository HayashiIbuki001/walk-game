using UnityEngine;

public class RestCommand : MonoBehaviour
{
    [SerializeField] PlayerStatus status;

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

    /// <summary> 通常休憩イベント </summary>
    private void EventA()
    {

        int addStaminaAmount = 30;

        status.AddStamina(addStaminaAmount);
        Debug.Log($"休憩イベントA : スタミナを{addStaminaAmount}回復");
    }

    /// <summary> 確率休憩イベント(バフ) </summary>
    private void EventB()
    {
        int addStaminaAmount = 50;

        status.AddStamina(addStaminaAmount);
        Debug.Log($"休憩イベントB : スタミナを{addStaminaAmount}回復");
    }

    /// <summary> 確率休憩イベント(デバフ) </summary>
    private void EventC()
    {
        int addStaminaAmount = 10;

        status.AddStamina(addStaminaAmount);
        Debug.Log($"休憩イベントC : スタミナを{addStaminaAmount}回復");
    }
}
