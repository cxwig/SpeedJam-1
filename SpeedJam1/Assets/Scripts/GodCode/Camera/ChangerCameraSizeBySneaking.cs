using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerCameraSizeBySneaking : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float _increaseDuration = 2;
    [SerializeField] private float _decreaseDuration = 3;
    [SerializeField] private float _minSize = 3.6f;
    [SerializeField] private GetterPlayerMove _getterPlayerMove;
    private ChangerSizeOfCamera _changerSizeOfCamera;
    private void Awake()
    {
        _changerSizeOfCamera = new ChangerSizeOfCamera(_camera);
        _getterPlayerMove.OnMove += StartIncreasingSizeOfCamera;
        _getterPlayerMove.OnSneak += StartReturnuingStartSize;
    }
    private void StartReturnuingStartSize() => StartCoroutine(_changerSizeOfCamera.ChangerSizeOfCameraByTime(() => _camera.orthographicSize > _minSize, -1, _decreaseDuration));
    
    private void StartIncreasingSizeOfCamera() => StartCoroutine(_changerSizeOfCamera.ChangerSizeOfCameraByTime(() => _changerSizeOfCamera.CameraSize > _camera.orthographicSize, 1, _increaseDuration));
    
    private void OnDisable()
    {
        _getterPlayerMove.OnMove -= StartIncreasingSizeOfCamera;
        _getterPlayerMove.OnSneak -= StartReturnuingStartSize;
    }
}
