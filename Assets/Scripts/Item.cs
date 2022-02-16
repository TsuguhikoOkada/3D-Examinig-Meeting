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

    [SerializeField,Header("アイテムの種類")]public Type _type;

    [SerializeField,Header("スロットに表示するスプライト画像")]public Sprite _sprite;

    [SerializeField] public GameObject _zoomObj;

    public Item (Type type , Sprite sprite, GameObject zoomObj)
    {
        this._type = type;
        this._sprite = sprite;
        this._zoomObj = zoomObj;
    }
}
