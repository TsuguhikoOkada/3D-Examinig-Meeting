using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
    // アイテムを持っている状態でクリックすると消える(クリック判定、アイテム所持判定)

    [SerializeField, Header("解除できるアイテム")] Item.Type _clearItem;

    public void OnClickObj()
    {
        Debug.Log("クリックしました！");

        // アイテムを持っているか否か？
        bool clear = ItemBox.instance.TryUseItem(_clearItem);

        if (clear == true)
        {
            Debug.Log("ギミックを解除しました");
            gameObject.SetActive(false);
        }
    }
}
