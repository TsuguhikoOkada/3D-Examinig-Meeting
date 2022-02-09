using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// アイテムをデータベース化するためのスクリプト
/// </summary>

[CreateAssetMenu]
public class ItemListEntity : ScriptableObject
{
    public List<Item> itemList = new List<Item>();
}
