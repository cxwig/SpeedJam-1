using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public IBehaviour Behaviour { get; private set; }

    public void Initialize(IBehaviour behaviour)
    {
        Behaviour = behaviour;
    }

    private void FixedUpdate()
    {
        Behaviour.Behave();
    }
}
