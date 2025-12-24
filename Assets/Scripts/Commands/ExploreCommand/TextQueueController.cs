using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using TMPro;

public class TextQueueController : MonoBehaviour
{
    public static TextQueueController Instance;

    Queue<string> textQueue = new();
    bool isShowing;
    private Coroutine typingCoroutine;

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
        string nextText = textQueue.Dequeue();
        gameObject.SetActive(true);

        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }

        typingCoroutine = StartCoroutine(TypeText(nextText));
    }

    private IEnumerator TypeText(string message)
    {
        isShowing = true;
        textUI.text = "";

        foreach (char c in message)
        {
            textUI.text += c;
            yield return new WaitForSeconds(0.03f);
        }

        typingCoroutine = null;
    }

    public void OnClickNext()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
            textUI.text = textQueue.Peek();
            typingCoroutine = null;
            return;
        }

        ShowNext();
    }
}
