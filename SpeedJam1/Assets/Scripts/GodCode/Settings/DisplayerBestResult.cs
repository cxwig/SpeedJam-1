using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayerBestResult : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private void Awake()
    {
        GetterBestTimeHandler getterBestTimeHandler = new GetterBestTimeHandler();
        var result = getterBestTimeHandler.GetBestResult();
        if (result.Item1 == false)
        {
            _text.gameObject.SetActive(false);
        }
        _text.text = result.Item2.ToString();
    }
}
