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
    [SerializeField] private GameObject mainCanvas;

    void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (isShowing && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ShowNext();
        }
    }

    public void Enqueue(string message)
    {
        textQueue.Enqueue(message);

        if (!isShowing)
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

            mainCanvas.SetActive(true);

            return;
        }

        isShowing = true;
        textUI.text = textQueue.Dequeue();
        gameObject.SetActive(true);
    }
}
