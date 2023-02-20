using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Player))]
[RequireComponent(typeof(GetterPlayerMove))]
public class PlayerInitializer : MonoBehaviour
{
    public Player Player { get; private set; }
    private IGetterRotation _getterRotation;
    public GetterPlayerMove GetterMove { get; private set; }
    private IBehaviour _behaviour;
    private void Awake()
    {
        GetterMove = GetComponent<GetterPlayerMove>();
        _getterRotation = GetComponent<IGetterRotation>();
        Player = GetComponent<Player>();
        _behaviour = new ActiveBehaviour(GetterMove.GetMove(), _getterRotation.GetRotation());
        Initialize();
    }
    public void Initialize()
    {
        Player.Initialize(_behaviour);
    }
}
