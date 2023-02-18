using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReturnerVector
{
    public ReturnerCurrentSpeed ReturnerSpeed { get; set; }
    public Vector3 ReturnVector();
}
