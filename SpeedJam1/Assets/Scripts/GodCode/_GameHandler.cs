using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class _GameHandler : MonoBehaviour
{
    [SerializeField] private _WindowPointer windowPointer;

    // this doesnt work fix juno please..
    private void Start()
    {
        windowPointer.Show(new Vector3(5, 20));

        int state = 0;
        FunctionUpdater.Create(() =>
        {
            switch (state)
            {
                case 0:
                    if (Vector3.Distance(Camera.main.transform.position, new Vector3(5, 20)) < 10)
                    {
                        windowPointer.Show(new Vector3(5, -50));
                        state = 1;
                    }
                    break;
                case 1:
                    if (Vector3.Distance(Camera.main.transform.position, new Vector3(5, -50)) < 15)
                    { 
                        windowPointer.Hide();
                        state = 2;
                    }
                    break;
            }
        });
    }
}
