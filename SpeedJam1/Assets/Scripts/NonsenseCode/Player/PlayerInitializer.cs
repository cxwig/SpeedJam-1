using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Player))]
[RequireComponent(typeof(IGetterMove))]
public class PlayerInitializer : MonoBehaviour
{
    private Player _player;
    public IGetterMove GetterMove { get; private set; }
    private void Awake()
    {
        GetterMove = GetComponent<IGetterMove>();
        _player = GetComponent<Player>();
        Initialize();
    }
    public void Initialize()
    {
        _player.Initialize(GetterMove.GetMove());
    }
}
