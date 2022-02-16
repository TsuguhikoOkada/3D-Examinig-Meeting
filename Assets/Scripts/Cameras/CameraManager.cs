using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カメラを切り替えるスクリプト
/// </summary>

public class CameraManager : MonoBehaviour
{
    // どこにどのカメラを有効にするか?
    // Mainの全体を回転するカメラ
    // ズーム表示時のカメラ
    // Move時のカメラ

    // 全体カメラのポジションを作成
    [SerializeField, Header("回転カメラポジション")] Transform[] _mainCameraPosition = default;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position = _mainCameraPosition[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
