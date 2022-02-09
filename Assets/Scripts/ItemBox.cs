using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{

    [SerializeField, Header("アイテムスロット")] Slot[] slots = default;

    /// <summary>
    /// ItemBoxのインスタンスを生成
    /// </summary>
    public static ItemBox instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    /// <summary>
    ///  アイテムをクリックしたら、スロットにアイテムを入れていく
    /// </summary>
    /// <param name="item"></param>
    public void SetItem(Item item)
    {
        foreach (Slot slot in slots) // slotsの数だけ回す
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item); // スロットにアイテムを入れる

                break; // 空のスロットにアイテムを入れたらループを抜ける
            }
        }
            
    }
}
