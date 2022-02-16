using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///  取ったアイテムを格納するスロットのスクリプト
/// </summary>

public class Slot : MonoBehaviour
{
    /// <summary>
    /// スロットにアイテムを持たせる(初期はデフォルト設定)
    /// </summary>/// 
    Item _slotitem = default;

    /// <summary>
    /// アイテムを受け取ったら画像をスロットに表示するため初期はデフォルト設定
    /// </summary>/// 
    [SerializeField] Image image = default;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] GameObject _bgPanel = default;

     void Awake()
    {
        //image = GetComponent<Image>(); // imageにimageコンポーネントを入れる
    }

    void Start()
    {
        _bgPanel.SetActive(false); 
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
    public Item GetItem()
    {
        return _slotitem;
    }

    /// <summary>
    /// 取ったアイテムを画像としてスロットに表示
    /// </summary>
    /// <param name="item"></param>
    void UpdateImage(Item item)
    {
        if (item == null)
        {
            image.sprite = null;
        }
        else
        {
            image.sprite = item._sprite; // Slotのimageにクリックしたアイテムのspriteを入れる
        }
    }

    /// <summary>
    /// 選択されているかを調べる
    /// </summary>
    /// <returns></returns>
    public bool Onselected()
    {

        if (_slotitem == null)
        {
            return false;
        }

        _bgPanel.SetActive(true);

        return true;

    }

    public void HideBGPanel()
    {
        _bgPanel.SetActive(false);
    }
}
