using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : IMove
{
    private Rigidbody2D _rigidbody2D;
    private Transform _transform;
    public IReturnerVector ReturnerVector { get; set; }

    public RigidbodyMovement(Transform transform, Rigidbody2D rigidbody2D, IReturnerVector returnerVector)
    {
        _rigidbody2D = rigidbody2D;
        ReturnerVector = returnerVector;
    }

    public void Move()
    {
        _rigidbody2D.velocity = ReturnerVector.ReturnVector();
    }

}
