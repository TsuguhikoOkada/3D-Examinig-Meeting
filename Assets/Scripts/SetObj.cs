using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObj : MonoBehaviour
{
    [SerializeField] GameObject _setObject;

    [SerializeField] Item.Type _useItem;

    // 適切なオブジェクトを選択した状態で、このオブジェクトをクリックしたら

    public void OnClickThis()
    {
        bool hasItem = ItemBox.instance.TryUseItem(_useItem);

        if (hasItem)
        {
            // アイテムを表示
            _setObject.SetActive(true);
        }
        
    }

}
