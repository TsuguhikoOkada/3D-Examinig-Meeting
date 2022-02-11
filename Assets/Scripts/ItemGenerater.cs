using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    /// <summary>データベースを入れる箱</summary>///
    [SerializeField,Header("アイテムデータベース")] ItemListEntity itemListEntity = default;

    /// <summary>ItemGeneraterのインスタンス生成</summary>///
    public static ItemGenerater instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // PickupObjスクリプトのstart関数で実行
    public Item Spwan(Item.Type type)
    {

        foreach (Item item in itemListEntity.itemList)
        {
            if (item.type == type)
            {
                return new Item(item.type, item.sprite);
            }
        }

        return null;

    }
}
