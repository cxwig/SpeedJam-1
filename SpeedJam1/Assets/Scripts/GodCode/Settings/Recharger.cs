using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Recharger : MonoBehaviour
{
    public bool IsCoolDown { get; private set; } = true;
    private int _reloadTime;
    public Recharger(int reloadTime)
    {
        _reloadTime = reloadTime;
    }
    public void CoolDown()
    {
        IsCoolDown = false;
        Timer timer = new Timer(Reload, null, _reloadTime, Timeout.Infinite);
    }
    private void Reload(object obj)
    {
        IsCoolDown = true;
    }

}
