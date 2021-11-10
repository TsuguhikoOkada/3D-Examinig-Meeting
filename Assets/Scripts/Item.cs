using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item : MonoBehaviour
{
    // アイテムの種類を列挙型で並べている
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type m_type; // 種類
    public Sprite m_slotsprite; // Slotに表示する画像
}
