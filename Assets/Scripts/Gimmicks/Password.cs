using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Password : MonoBehaviour
{
    /// <summary>正しいナンバーだと外の関数を呼び出してイベント発生</summary>///
    [SerializeField,Header("正解のナンバーで実行されるイベント")] public UnityEvent _clearEvent;
    /// <summary>正しいナンバー</summary>///
    [SerializeField, Header("正解のナンバー")] int[] _correctNumbers;

    /// <summary>今の数値(PasswordButtonのナンバーをチェック)</summary>///
    [SerializeField, Header("現在の表示されている数値")] PasswordButton [] _passwordButtons;
    // 現在のパネルの数値と正解の比較

    [SerializeField]EventTrigger [] _triggers;

    public void CorrectCheck()
    {
        if (IsCorrect())
        {
            Debug.Log("正解");

            _clearEvent.Invoke();

            for (int i = 0; i < _correctNumbers.Length; i++)
            {
                _triggers [i].enabled = false;
            }
        }
    }

    bool IsCorrect()
    {
        // 正解のチェック
        for (int i = 0; i < _correctNumbers.Length ; i++)
        {
            if (_passwordButtons[i]._number != _correctNumbers[i])
            {
                return false;
            }
        }

        
        return true;
        
        
    }
}
