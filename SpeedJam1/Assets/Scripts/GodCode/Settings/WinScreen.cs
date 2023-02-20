using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinScreen : MonoBehaviour
{
    [SerializeField] private WinnerGameItem _winner;
    [SerializeField] private CanvasGroup _canvasGroup;
    private bool _isTrigged;
    private void Awake()
    {
        _winner.OnWin += DisplayWin;
    }
    private void DisplayWin()
    {
        if (_isTrigged == false)
        {
            _canvasGroup.ChangeStateOfCanvasGroup(true);
            StartCoroutine(CoolDown());
        }
    }
    private IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }
}
