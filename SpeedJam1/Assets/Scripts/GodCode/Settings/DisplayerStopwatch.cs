using System;
using TMPro;
using UnityEngine;

public class DisplayerStopwatch : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Stopwatch _stopwatch;
    [SerializeField] private int _digits = 2;
    private float _time = 0;
    private void Update()
    {
        _time += Time.deltaTime;
        if (_time > 0.1f)
        {
            _text.text = $"{Math.Round(_stopwatch.CurrentTime, _digits)}";
            _time = 0;
        }
        // if (Input.GetKeyDown(KeyCode.J))
        // {
        //}
    }
}
