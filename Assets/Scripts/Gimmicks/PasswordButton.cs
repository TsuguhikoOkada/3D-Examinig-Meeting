﻿using UnityEngine;
using TMPro;

public class PasswordButton : MonoBehaviour
{
    [SerializeField] TMP_Text _numberText;
    [SerializeField] public int _number;

    void Start()
    {
        _number = 0;
        _numberText.text = _number.ToString();
    }
    // 実行されたら数値を変える
    public void OnClickThis()
    {
        _number++;

        if (_number > 9)
        {
            _number = 0;
        }

        _numberText.text = _number.ToString();
    }
}
