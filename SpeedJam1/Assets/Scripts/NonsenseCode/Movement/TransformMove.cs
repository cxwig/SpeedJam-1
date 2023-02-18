using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMove : IMove
{
    private Transform _transform;
    public IReturnerVector ReturnerVector { get; set; }

    public TransformMove(Transform transform, IReturnerVector returnerVector)
    {
        _transform = transform;
        ReturnerVector = returnerVector;
    }

    public void Move()
    {
        _transform.position = ReturnerVector.ReturnVector();
    }


}
