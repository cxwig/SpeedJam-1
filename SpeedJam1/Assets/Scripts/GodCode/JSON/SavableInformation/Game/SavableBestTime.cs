using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavableBestTime : ISavable
{
   public string BestTime;
   public SavableBestTime(string bestTime)
   {
    BestTime = bestTime;
   }
   public SavableBestTime()
   {
    
   }
}
