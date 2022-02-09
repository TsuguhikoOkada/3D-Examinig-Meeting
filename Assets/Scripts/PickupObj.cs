using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType = default;

    Item item = default;

    void Start()
    {
        //itemTypeに応じてitemを生成する(アイテムに対してTypeとSpriteを設定する）
        item = ItemGenerater.instance.Spwan(itemType);
    }

    /// <summary>
    /// クリックしてステージにあるアイテムを消す
    /// </summary>
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false); // アイテムオブジェクトを消す
    }
}
