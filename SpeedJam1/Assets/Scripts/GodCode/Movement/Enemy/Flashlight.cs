using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private IRotation _rotation;

    public void Initialize(IRotation rotation)
    {
        _rotation = rotation;
    }

    private void Update()
    {
        _rotation.Rotate();
    }

}
