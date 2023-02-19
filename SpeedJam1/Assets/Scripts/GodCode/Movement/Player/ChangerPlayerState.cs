using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangerPlayerState : MonoBehaviour
{
    public event Action OnSneak;
    public event Action OnMove;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSneak?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            OnMove?.Invoke();

        }
    }

}
