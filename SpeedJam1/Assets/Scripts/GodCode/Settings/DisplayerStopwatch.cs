using System;
using TMPro;
using UnityEngine;

public class DisplayerStopwatch : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Stopwatch _stopwatch;
    [SerializeField] private int _digits = 2;
    [SerializeField] private float _maxTime = 120;
    private float _time = 0;

    public float MaxTime { get => _maxTime; set => _maxTime = value; }

    private void Update()
    {
        _time += Time.deltaTime;
        if (_time > 0.1f)
        {
            _text.text = $"{Math.Round(_maxTime - _stopwatch.CurrentTime, _digits)}";
            _time = 0;
        }
        // if (Input.GetKeyDown(KeyCode.J))
        // {
        //}
    }
}
