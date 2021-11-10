using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : Item
{
    // [SerializeField] Item.Type item = default;

    [SerializeField, Header("アイテムの種類")] Item item = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // クリックすると消える
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false); // アイテムオブジェクトを消す
    }
}
