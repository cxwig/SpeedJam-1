using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Enemy))]
[RequireComponent(typeof(IGetterMove))]
public class EnemyInitilizator : MonoBehaviour
{
    private Enemy _enemy;
    public IGetterMove GetterMove { get; private set; }
    private void Start()
    {
        GetterMove = GetComponent<IGetterMove>();
        _enemy = GetComponent<Enemy>();
    }
    private void LateUpdate()
    {
        Initialize();
    }
    public void Initialize()
    {
        _enemy.Initialize(GetterMove.GetMove());
    }

}
