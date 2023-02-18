using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerCameraSizeBySpeedUp : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float _increaseDuration = 2;
    [SerializeField] private float _decreaseDuration = 3;
    [SerializeField] private float _maxSize = 8;
    [SerializeField] private CollectorOfPowerUps _collectorOfPowerUps;
    private ChangerSizeOfCamera _changerSizeOfCamera;
    private void Awake()
    {
        _changerSizeOfCamera = new ChangerSizeOfCamera(_camera);
        _collectorOfPowerUps.OnPickUp += StartIncreasingSizeOfCamera;
        _collectorOfPowerUps.OnRemoveEffect += StartReturnuingStartSize;
    }
    private void StartReturnuingStartSize() => StartCoroutine(_changerSizeOfCamera.ChangerSizeOfCameraByTime(() => _camera.orthographicSize > _changerSizeOfCamera.CameraSize, -1, _decreaseDuration));

    private void StartIncreasingSizeOfCamera() => StartCoroutine(_changerSizeOfCamera.ChangerSizeOfCameraByTime(() => _maxSize > _camera.orthographicSize, 1, _increaseDuration));

    private void OnDisable()
    {
        _collectorOfPowerUps.OnPickUp -= StartIncreasingSizeOfCamera;
        _collectorOfPowerUps.OnRemoveEffect -= StartReturnuingStartSize;
    }

}
