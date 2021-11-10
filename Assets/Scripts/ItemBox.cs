using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{

    [SerializeField, Header("アイテムスロット")] Slot[] slots = default;

    // とこでも実行可能にしている
    public static ItemBox instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // PickupObjがクリックされたら、スロットにアイテムを入れる

    public void SetItem(Item item)
    {
        slots[0].SetItem(item);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
