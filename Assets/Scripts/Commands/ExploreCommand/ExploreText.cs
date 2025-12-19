using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using TMPro;

public class ExploreText : MonoBehaviour
{
    public static ExploreText Instance;

    Queue<string> textQueue = new();
    bool isShowing;

    [SerializeField] TextMeshProUGUI textUI;

    void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }

    public void Enqueue(string message)
    {
        textQueue.Enqueue(message);

        if (!isShowing && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ShowNext();
        }
    }

    private void ShowNext()
    {
        if (textQueue.Count == 0)
        {
            isShowing = false;
            gameObject.SetActive(false);
            return;
        }

        isShowing = true;
        textUI.text = textQueue.Dequeue();
        gameObject.SetActive(true);
    }
}
