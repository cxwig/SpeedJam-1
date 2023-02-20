using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnderGame : MonoBehaviour
{
    [SerializeField] private Stopwatch _stopwatch;
    [SerializeField] private DisplayerStopwatch _displayerStopwatch;
    [SerializeField] private ShowerGameOver _showerGameOver;
    private void Update()
    {
        if (_stopwatch.CurrentTime > _displayerStopwatch.MaxTime)
        {
            _stopwatch.Stop();
            _showerGameOver.DisplayGameOver();
        }
    }
}
