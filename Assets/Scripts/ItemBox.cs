using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{

    [SerializeField, Header("アイテムスロット")] Slot[] slots = default;

    [Tooltip("Checkするために敢えてnullにしているので、この項目には何も入れてない")]
    [SerializeField,Header("どのスロットが選択されているか")]
     Slot _selectedSlot = null;

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

        _selectedSlot = null;

        // 選択されたスロットの選択パネルを表示
        if (slots[position].Onselected())
        {
            _selectedSlot = slots[position];
        }   
    }

    /// <summary>
    /// 試しにアイテムを使えるか調べる
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public bool TryUseItem(Item.Type type)
    {
        // 選択されたスロットの有無を調べる
        if (_selectedSlot == null)
        {
            return false;
        }
        if (_selectedSlot.GetItem()._type == type)
        {
            _selectedSlot.SetItem(null);
            _selectedSlot.HideBGPanel();
            _selectedSlot = null;

            return true;
        }

        return false;

    }

    public Item GetSelectedItem()
    {
        if (_selectedSlot == null)
        {
            return null;
        }
        return _selectedSlot.GetItem();
    }
}
