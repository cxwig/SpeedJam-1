using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterBestTimeHandler
{
    public (bool,float) GetBestResult()
    {
        SavableBestTime savableBestTime = Loader<SavableBestTime>.Load(new SavableBestTime());
        float minTime = 0;
        bool result = false;
        if (savableBestTime != null && savableBestTime.BestTime != "")
        {
            result = float.TryParse(savableBestTime.BestTime, out minTime);
        }
        return (result, minTime);
    }
}
