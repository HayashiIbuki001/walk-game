using UnityEngine;

[CreateAssetMenu(fileName = "ExploreMapData", menuName = "Walk Game/ExploreMapData")]
public class ExploreMapData : ScriptableObject
{
    public string MapName;
    public ItemData[] DropItems;
    public ExploreEventProbability[] eventTable;
}
