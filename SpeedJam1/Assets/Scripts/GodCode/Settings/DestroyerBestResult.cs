using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBestResult : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Saver<SavableBestTime>.Save(new SavableBestTime(""));
        }
    }
}
