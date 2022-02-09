using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : Item
{

    [SerializeField, Header("アイテムの種類")] Item item = default;

    /// <summary>
    /// クリックしてステージにあるアイテムを消す
    /// </summary>
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false); // アイテムオブジェクトを消す
    }
}
