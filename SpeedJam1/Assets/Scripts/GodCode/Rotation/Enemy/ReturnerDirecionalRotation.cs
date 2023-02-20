using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerDirecionalRotation : IReturnerRotation
{
    private Transform _transform;
    public ReturnerDirecionalRotation(Transform transform)
    {
        _transform = transform;
    }
    public Vector3 ReturnRotation() => new Vector2(_transform.localScale.x , _transform.localScale.y);
  
}
