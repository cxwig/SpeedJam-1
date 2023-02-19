using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerRotationByMovement : IReturnerRotation
{
    private IReturnerVector _returnerVector;
    private Transform _scale;
    private float _startScale;
    public ReturnerRotationByMovement(IReturnerVector returnerVector, Transform scale)
    {
        _returnerVector = returnerVector;
        _scale = scale;
        _startScale = _scale.localScale.x;
    }

    public Vector3 ReturnRotation()
    {
        Vector3 size = _scale.localScale;
        float xOfVector = _returnerVector.ReturnVector().x;
        if (xOfVector.IsEqualZero() == false)
        {
             size = Flip(_startScale, false,xOfVector, _scale.localScale.y);
        }
        return size;
    }
    private Vector2 Flip(float startScale, bool isNegativy, float xOfVector, float y)
    {
        float x = startScale;
        x *= xOfVector.IsNegative().NegativityByCondition() * isNegativy.NegativityByCondition();
        return new Vector2(x, y);
    }
}
