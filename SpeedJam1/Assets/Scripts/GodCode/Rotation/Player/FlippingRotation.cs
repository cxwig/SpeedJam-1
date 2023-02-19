using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippingRotation : IRotation
{
    public IReturnerRotation ReturnerRotation { get; set; }
    private Transform _currentTransform;

    public FlippingRotation(Transform currentTransform, IReturnerRotation returnerRotation)
    {
        _currentTransform = currentTransform;
        ReturnerRotation = returnerRotation;
    }
    public void Rotate()
    {
        _currentTransform.transform.localScale = ReturnerRotation.ReturnRotation();
    }
}
