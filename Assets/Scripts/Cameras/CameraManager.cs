using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カメラを切り替えるスクリプト
/// </summary>

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject _leftArrowObj;
    [SerializeField] GameObject _rightArrowObj;
    [SerializeField] GameObject _backArrowObj;

    // ズーム表示時のカメラ
    Camera _carrentCamera;
    // 保持するカメラ
    Camera _mainCamera;
    // 全体カメラのポジションを作成
    [SerializeField, Header("回転カメラポジション")] Transform[] _mainCameraTransforms ;

    int _currentMainPosition;

    /// <summary>CameraManagerのインスタンス</summary>///
    public static CameraManager instance;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        _backArrowObj.SetActive(false);
        _mainCamera = Camera.main;
        _carrentCamera = Camera.main;
        _currentMainPosition = 0;
        _carrentCamera.transform.position = _mainCameraTransforms[_currentMainPosition].position;
        _carrentCamera.transform.rotation = _mainCameraTransforms[_currentMainPosition].rotation;
    }

    public void TurnLeft()
    {
        _currentMainPosition--;

        if (_currentMainPosition < 0)
        {
            _currentMainPosition = _mainCameraTransforms.Length - 1;
        }

        _carrentCamera.transform.position = _mainCameraTransforms[_currentMainPosition].position;
        _carrentCamera.transform.rotation = _mainCameraTransforms[_currentMainPosition].rotation;
    }

    public void TurnRight()
    {
        _currentMainPosition++;

        if (_currentMainPosition >= _mainCameraTransforms.Length)
        {
            _currentMainPosition = 0;
        }

        _carrentCamera.transform.position = _mainCameraTransforms[_currentMainPosition].position;
        _carrentCamera.transform.rotation = _mainCameraTransforms[_currentMainPosition].rotation;
    }

    public void SetZoomCamera(Camera camera)
    {
        _carrentCamera.gameObject.SetActive(false);
        camera.gameObject.SetActive(true);
        _carrentCamera = camera;
        _backArrowObj.SetActive(true);
        _leftArrowObj.SetActive(false);
        _rightArrowObj.SetActive(false);
    }

    public void UnZoomButton()
    {
        _mainCamera.gameObject.SetActive(true);
        _carrentCamera.gameObject.SetActive(false);
        _carrentCamera = _mainCamera;
        _backArrowObj.SetActive(false);
        _leftArrowObj.SetActive(true);
        _rightArrowObj.SetActive(true);
    }
}
