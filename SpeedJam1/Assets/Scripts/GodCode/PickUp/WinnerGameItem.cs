using System.Collections;
using System;
using UnityEngine;


public class WinnerGameItem : MonoBehaviour
{
    [SerializeField] private Stopwatch _stopwatch;
    public event Action OnWin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.TriggerEntity<Player>((player) =>
        {
            GetterBestTimeHandler getterBestTimeHandler = new GetterBestTimeHandler();
            var result = getterBestTimeHandler.GetBestResult();
            if (_stopwatch.CurrentTime < result.Item2 || result.Item1 == false)
            {
                result.Item2 = _stopwatch.CurrentTime;
                Saver<SavableBestTime>.Save(new SavableBestTime(result.Item2.ToString()));
                OnWin?.Invoke();
            } 
        });
    }
}
