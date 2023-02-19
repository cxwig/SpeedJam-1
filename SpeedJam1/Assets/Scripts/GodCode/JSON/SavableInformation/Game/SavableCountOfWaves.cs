using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavableCountOfWaves : ISavable
{
   public string CountOfWaves;
   public SavableCountOfWaves(string countOfScores)
   {
    CountOfWaves = countOfScores;
   }
   public SavableCountOfWaves()
   {
    
   }
}
