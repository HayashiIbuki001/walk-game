using UnityEngine;

public class WalkCommand : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] PlayerStatus status;

    public void ClickWalkButton()
    {
        int addProgress = Random.Range(3, 8);
        gameManager.ProgressUpdate(addProgress);

        int removeStamina = Random.Range(10, 21) * -1;
        status.AddStamina(removeStamina);
    }
}
