using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : IMove
{
    private Transform _transform;
    public IReturnerVector ReturnerVector { get; set; }
    
    public PlayerMovement(Transform transform, IReturnerVector returnerVector)
    {
        _transform = transform;
        ReturnerVector = returnerVector;
    }

    public void Move()
    {
        _transform.position += ReturnerVector.ReturnVector();
    }

}
