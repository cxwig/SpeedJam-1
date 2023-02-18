using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerSizeOfCamera
{
    private Camera _camera;
    public ChangerSizeOfCamera(Camera camera)
    {
        _camera = camera;
        CameraSize = _camera.orthographicSize;
    }

    public float CameraSize { get; private set; }

    /* private void StartReturnuingStartSize()
{
StartCoroutine(ChangeSizeOfCamera(() => _camera.orthographicSize > _cameraSize, -1));
}
private void StartIncreasingSizeOfCamera()
{
StartCoroutine(ChangeSizeOfCamera(() => _maxSize > _camera.orthographicSize, 1));
}*/
    public IEnumerator ChangerSizeOfCameraByTime(Func<bool> func, float factorOfNegativity, float speed)
    {
        float time = 0;
        while (func())
        {
            time += Time.deltaTime;
            _camera.orthographicSize = _camera.orthographicSize + CameraSize * factorOfNegativity * speed * time;
            yield return null;
        }

    }
    public IEnumerator ChangeSizeOfCamera(Func<bool> func, float factorOfNegativity, float duration)
    {
        float time = 0;
        while (func())
        {
            time += Time.deltaTime;
            _camera.orthographicSize = _camera.orthographicSize + CameraSize * factorOfNegativity / duration * time;
            yield return null;
        }
    }
  /*  private IEnumerator DecreaseSize()
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
            _camera.orthographicSize = _camera.orthographicSize + _cameraSize / _increaseDuration * time; 
            yield return null;
        }
    }*/

}
