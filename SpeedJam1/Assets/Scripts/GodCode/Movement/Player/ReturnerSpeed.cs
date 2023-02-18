using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerSpeed : ReturnerCurrentSpeed
{
    public float Speed { get; set; }
    public ReturnerSpeed(float speed)
    {
        Speed = speed;
    }
    public override float ReturnSpeed() => Speed;

}
