using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item 
{
    /// <summary>
    /// アイテムの種類をenumで整理
    /// </summary>
    public enum Type
    {
        Cube,
        Ball,
    }

    [SerializeField,Header("アイテムの種類")]public Type type;

    [SerializeField,Header("スロットに表示するスプライト画像")]public Sprite sprite;

    public Item (Type type , Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
