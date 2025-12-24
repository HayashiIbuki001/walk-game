using UnityEngine;
using static UnityEditor.Progress;

public class ParkEventController : MonoBehaviour
{

    public void Execute(int index)
    {
        switch (index)
        { 
            case 0: EventA(); break;
            case 1: EventB(); break;
            case 2: EventC(); break;
            default: Debug.Log("No Event"); break;
        }
    }

    public void EventA()
    {
        TextQueueController.Instance.Enqueue($"草むらを見渡していると、四つ葉のクローバーをみつけた。\n今日は運がついているかもしれない。");
        TextQueueController.Instance.Enqueue($"体力が10、スタミナが20回復した。");
    }

    public void EventB()
    {
        TextQueueController.Instance.Enqueue($"ベンチを見つけた。少し休憩していこう。\nベンチに腰を下ろした。");
        TextQueueController.Instance.Enqueue($"スタミナが15回復した。");
    }

    public void EventC()
    {
        TextQueueController.Instance.Enqueue($"ふと空を見上げると、カラスがこっちに来ている！\nカラスはなにかを持って飛び去って行った...");

        string removedItem;
        Inventory.Instance.RemoveRandomItem(out removedItem);

        if (!string.IsNullOrEmpty(removedItem))
        {
            TextQueueController.Instance.Enqueue($"{removedItem}を失った...");
        }
        else
        {
            TextQueueController.Instance.Enqueue($"何も失うものがない。");
        }
    }
}
