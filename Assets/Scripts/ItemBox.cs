using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{

    [SerializeField, Header("アイテムスロット")] Slot[] slots = default;

    [Tooltip("Checkするために敢えてnullにしているので、この項目には何も入れないこと")]
    [SerializeField,Header("どのスロットが選択されているか")]Slot _selectedSlot = null;

    /// <summary>
    /// ItemBoxのインスタンスを生成
    /// </summary>///
    public static ItemBox instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            // slot子オブジェクトにSlotスクリプトを入れる
            slots = GetComponentsInChildren<Slot>();
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

    public void OnSelectSlot(int position)
    {
        // 一旦全てのスロットの選択パネルを非表示
        foreach (Slot slot in slots)
        {
            slot.HideBGPanel();
        }

        // 選択されたスロットの選択パネルを表示
        if (slots[position].Onselected())
        {
            _selectedSlot = slots[position];
        }

        
    }
}
