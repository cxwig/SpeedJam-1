using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro.Examples;

public class ShakerText : MonoBehaviour
{
    [SerializeField] private VertexJitter _vertexJitter;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            _vertexJitter.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        { 
            _vertexJitter.ContinieMoving();
        }

    }
}
