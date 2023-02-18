using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Enemy))]
[RequireComponent(typeof(IGetterMove))]
public class EnemyInitilizator : MonoBehaviour
{
    private Enemy _enemy;
    public IGetterMove GetterMove { get; private set; }
    private void Awake()
    {
        GetterMove = GetComponent<IGetterMove>();
        _enemy = GetComponent<Enemy>();
        Initialize();
    }
    public void Initialize()
    {
        _enemy.Initialize(GetterMove.GetMove());
    }

}
