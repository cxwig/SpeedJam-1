using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MovableCamera))]
[RequireComponent(typeof(Camera))]
[RequireComponent(typeof(IGetterMove))]
public class CameraInitializer : MonoBehaviour
{
    private MovableCamera _movableCamera;
    private IGetterMove _getterMove;
    private void Awake()
    {
        _getterMove = GetComponent<IGetterMove>();
        _movableCamera = GetComponent<MovableCamera>();
        _movableCamera.Initialize(_getterMove.GetMove());
    }

}
