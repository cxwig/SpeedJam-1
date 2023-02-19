using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public static class Extensions 
{
    public static void DivideImageBar(this Image image, float biggerValue, float smallerValue)
    {
     float fillValue = (float)smallerValue;
     fillValue /= biggerValue;
    image.fillAmount = fillValue;
    }
    public static float NegativityByCondition(this bool boolean) => boolean ? 1 : -1; 
    public static T GetNextElement<T>(this List<T> list, T element)
    {
        if (list.Contains(element) == false || list.IsListEmpty())
        {
            throw new InvalidOperationException();
        }
        T nextElement;
        int index = list.IndexOf(element);
        if (index >= list.Count)
        {
            nextElement = list[0];
        }
        else
        {
            nextElement = list[index ++];
        }
        return nextElement;
    }
    public static bool IsEqualZero(this float number) => number == 0;
    public static bool IsNegative(this float number) => number < 0;
    public static bool IsListEmpty<T>(this List<T> list) => list.Count == 0; 
    public static void TriggerEntity<T>(this Collider2D other,Action<T> OnAction) where T : MonoBehaviour
    {
        if (other.TryGetComponent<T>(out T item))
        {
            OnAction.Invoke(item);
        }
    }
    public static void ChangeStateOfCanvasGroup(this CanvasGroup canvasGroup, bool isTunrOn)
    {
        canvasGroup.interactable = isTunrOn;
        canvasGroup.blocksRaycasts = isTunrOn;
        canvasGroup.alpha = isTunrOn ? 1 : 0;
    }
    public static T GetRandomElementOfList<T>(this List<T> list)
    {
        return list[Random.Range(0,list.Count)];
    }
}
