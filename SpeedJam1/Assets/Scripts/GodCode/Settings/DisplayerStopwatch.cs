using System;
using TMPro;
using UnityEngine;

public class DisplayerStopwatch : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Stopwatch _stopwatch;
    [SerializeField] private int _digits = 2;
    private void Update()
    {
        _text.text = $"{Math.Round(_stopwatch.CurrentTime,_digits)}";
    }
}
