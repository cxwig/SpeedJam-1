using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGetterMove
{
    public IMove GetMove();
    IMove Move { get; }
}
