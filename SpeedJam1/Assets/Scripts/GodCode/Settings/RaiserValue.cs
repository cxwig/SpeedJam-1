using System.Collections;
using System;
using UnityEngine;

public class RaiserValue
{
    private float _additionalValue;
    public RaiserValue(float additionalValue)
    {
        if (additionalValue <= 0)
        {
            throw new InvalidOperationException();
        }
        _additionalValue = additionalValue;
    }
    public float AdditionalValue() => _additionalValue;
}
