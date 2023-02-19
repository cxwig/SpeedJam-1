using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerGameItem : MonoBehaviour
{
    [SerializeField] private Stopwatch _stopwatch;
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
            } 
        });
    }
}
