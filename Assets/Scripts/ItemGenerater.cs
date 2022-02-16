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
            if (item._type == type)
            {
                return new Item(item._type, item._sprite , item._zoomObj);
            }
        }

        return null;

    }

    public GameObject GetZoomItem(Item.Type type)
    {
        foreach (Item item in itemListEntity.itemList)
        {
            if (item._type == type)
            {
                return item._zoomObj;
            }
        }
        return null;
    }
}
