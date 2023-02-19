using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject loaderUI;
    public Slider sliderLoad;

    public void LoadScene(int time)
    {
        StartCoroutine(LoadScene_Coroutine(time));
    }

    public IEnumerator LoadScene_Coroutine(int time)
    {
        sliderLoad.value = 0;
        loaderUI.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(time);
        asyncOperation.allowSceneActivation = false;

        float progress = 0;

        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            sliderLoad.value = progress;
            if (progress >= 0.9f)
            {
                sliderLoad.value = 1;
                asyncOperation.allowSceneActivation = true;

            }
            yield return null;
        }
    }
}
