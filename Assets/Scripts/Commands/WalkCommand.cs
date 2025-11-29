using UnityEngine;

public class WalkCommand : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public void ClickWalkButton()
    {
        int addProgress = Random.Range(3, 8);

        gameManager.ProgressUpdate(addProgress);
    }
}
