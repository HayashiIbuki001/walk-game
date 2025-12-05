using UnityEngine;

[System.Serializable]
public class ExploreEventProbability
{
    public string eventName;
    [Range(0f, 1f)] public float probability;
    public UnityEngine.Events.UnityEvent onEvent;
}
