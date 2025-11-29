using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary> ゴールまでの進捗率 </summary>
    private int progress = 0;

    // private int currentTurn = 0;

    private bool isClear = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProgressUpdate(int addProgress)
    {
        if (!isClear)
        {
            progress += addProgress;
            Debug.Log($"経過進捗率 : {progress}%");

            if (progress >= 100)
            {
                progress = 100;
                Debug.Log($"修正進捗率 : {progress}%");

                Clear();
            }
        }
    }

    private void Clear()
    {
        isClear = true;
        Debug.Log("Clear!!!");
    }
}
