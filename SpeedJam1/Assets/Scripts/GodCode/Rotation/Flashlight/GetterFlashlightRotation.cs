using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterFlashlightRotation : MonoBehaviour, IGetterRotation
{
    [SerializeField] private float _offset;
    [SerializeField] private Transform _target;
    private IRotation _rotation;
    public IRotation GetRotation()
    {
        if (_rotation == null)
        {
            _rotation = new FlashlightRotation(transform, new ReturnerGunRotation(transform, _target, _offset));
        }
        return _rotation;
    }

}
