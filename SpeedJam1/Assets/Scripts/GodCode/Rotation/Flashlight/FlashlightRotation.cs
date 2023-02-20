using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightRotation : IRotation
{
    private Transform _currentTransform;
    public IReturnerRotation ReturnerRotation { get; set; }
    public FlashlightRotation(Transform currentTransform, IReturnerRotation returnerRotation)
    {
        _currentTransform = currentTransform;
        ReturnerRotation = returnerRotation;
    }
    public void Rotate()
    {
        _currentTransform.transform.rotation = Quaternion.Euler(ReturnerRotation.ReturnRotation());
    }
}
