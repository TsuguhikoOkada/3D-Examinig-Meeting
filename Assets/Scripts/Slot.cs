using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///  取ったアイテムを格納するスロットのスクリプト
/// </summary>

public class Slot : MonoBehaviour
{
    /// <summary>スロットにアイテムを持たせる(初期はデフォルト設定)</summary>/// 
    Item _slotitem = default;

    /// <summary>アイテムを受け取ったら画像をスロットに表示するため初期はデフォルト設定</summary>/// 
    Image image = default;

    /// <summary>
    /// 
    /// </summary>
     void Awake()
    {
        image = GetComponent<Image>(); // imageにimageコンポーネントを入れる
    }

    /// <summary>
    /// スロット内のアイテムが空か調べる
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        if (_slotitem == null)
        {
            return true;
        }

        return false;

    }



    public void SetItem(Item item)
    {
        _slotitem = item;

        UpdateImage(item);
    }

    /// <summary>
    /// 取ったアイテムを画像としてスロットに表示
    /// </summary>
    /// <param name="item"></param>
    void UpdateImage(Item item)
    {
        image.sprite = item.sprite; // Slotのimageにクリックしたアイテムのspriteを入れる
    }
    
}
