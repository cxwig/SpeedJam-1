using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterPlayerRotation : MonoBehaviour, IGetterRotation
{
    private IGetterMove _getterMove;
    private IRotation _rotation;
    private void Awake()
    {
        _getterMove = GetComponent<IGetterMove>();
    }
    public IRotation GetRotation()
    {
        if (_rotation == null)
        {
            _rotation = new FlippingRotation(transform, new ReturnerRotationByMovement(_getterMove.GetMove().ReturnerVector, transform));
        }
        return _rotation; 
    }
}
