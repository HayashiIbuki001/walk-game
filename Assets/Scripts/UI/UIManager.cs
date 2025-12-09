using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainUICanvas;
    [SerializeField] private GameObject ExploreUICanvas;

    public void ShowMain()
    {
        MainUICanvas.SetActive(true);
        ExploreUICanvas.SetActive(false);
    }

    public void ShowExplore()
    {
        MainUICanvas.SetActive(false);
        ExploreUICanvas.SetActive(true);
    }
}
