using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary> ÉSÅ[ÉãÇ‹Ç≈ÇÃêiíªó¶ </summary>
    private int progress = 0;

    // private int currentTurn = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ProgressUpdate(int addProgress)
    {
        progress += addProgress;
        Debug.Log($"êiíªó¶ : {progress}%");

        if ( progress >= 100 )
        {
            progress = 100;
            isClear();
        }
    }

    public void ClickWalkButton()
    {
        int addProgress = UnityEngine.Random.Range(3, 8);

        ProgressUpdate(addProgress);
    }

    private void isClear()
    {

    }
}
