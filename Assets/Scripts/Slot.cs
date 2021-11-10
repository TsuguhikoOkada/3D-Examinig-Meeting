using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    // アイテムを受け取ったら画像をスロットに表示
    Image image = default;


     void Awake()
    {
        image = GetComponent<Image>(); // imageにimageコンポーネントを入れる
    }



    public void SetItem(Item item)
    {
        UpdateImage(item);
    }


    void UpdateImage(Item item)
    {
        image.sprite = item.m_slotsprite; // Slotのimageにクリックしたアイテムのspriteを入れる
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
