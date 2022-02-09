using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item : MonoBehaviour
{
    /// <summary>
    /// アイテムの種類をenumで整理
    /// </summary>
    public enum Type
    {
        Cube,
        Ball,
    }

    [SerializeField,Header("アイテムの種類")]public Type m_type;

    [SerializeField,Header("スロットに表示するスプライト画像")]public Sprite m_slotsprite;
}
