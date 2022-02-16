using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomObj : MonoBehaviour
{
    /// <summary>ズームカメラの変数</summary>///
    [SerializeField, Header("ズームカメラ")] Camera _zoomCamera;

    // クリックしたらズーム位置を記録したカメラに切り替える
    public void OnClickThis()
    {
        Debug.Log("カメラ切り替え");
        CameraManager.instance.SetZoomCamera(_zoomCamera);
    }
}
