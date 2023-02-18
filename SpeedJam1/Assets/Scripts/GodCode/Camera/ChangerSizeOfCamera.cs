using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerSizeOfCamera : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float _increaseDuration = 2;
    [SerializeField] private float _decreaseDuration = 1;
    [SerializeField] private float _maxSize = 8;
    [SerializeField] private CollectorOfPowerUps _collectorOfPowerUps;
    private float _cameraSize;
    private void Awake()
    {
        _cameraSize = _camera.orthographicSize;
        _collectorOfPowerUps.OnPickUp += StartIncreasingSizeOfCamera;
        _collectorOfPowerUps.OnRemoveEffect += StartReturnuingStartSize;
    }
    private void StartReturnuingStartSize()
    {
        StartCoroutine(DecreaseSize());
    }
    private void StartIncreasingSizeOfCamera()
    {
        StartCoroutine(IncreaseSize());
    }
    private IEnumerator DecreaseSize()
    {
        float time = 0;
        while (_camera.orthographicSize > _cameraSize)
        {
            time += Time.deltaTime;
            _camera.orthographicSize = _camera.orthographicSize - _cameraSize / _decreaseDuration * time;
            yield return null;
        }
    }
    private IEnumerator IncreaseSize()
    {
        float time = 0;
        while (_maxSize > _camera.orthographicSize)
        {
            time += Time.deltaTime;
            _camera.orthographicSize = _cameraSize + _cameraSize / _increaseDuration * time; 
            yield return null;
        }
    }
    private void OnDisable()
    {
        _collectorOfPowerUps.OnPickUp -= StartIncreasingSizeOfCamera;
        _collectorOfPowerUps.OnRemoveEffect -= StartReturnuingStartSize;
    }
}
