using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoupeCatch : MonoBehaviour
{
    [SerializeField] GameObject _lopeObj;

    void Start()
    {
        _lopeObj.SetActive(false);
    }
    public void Catch()
    {
        _lopeObj.SetActive(true);
    }
}
