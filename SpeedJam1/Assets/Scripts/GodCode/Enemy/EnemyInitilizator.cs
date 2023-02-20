using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Enemy))]
[RequireComponent(typeof(IGetterMove))]
[RequireComponent(typeof(IGetterRotation))]
public class EnemyInitilizator : MonoBehaviour
{
    private IGetterRotation _getterRotation;
    private Enemy _enemy;
    public IGetterMove GetterMove { get; private set; }
    private void Start()
    {
        _getterRotation = GetComponent<IGetterRotation>();
        GetterMove = GetComponent<IGetterMove>();
        _enemy = GetComponent<Enemy>();
    }
    private void LateUpdate()
    {
        Initialize();
    }
    public void Initialize()
    {
        _enemy.Initialize(GetterMove.GetMove(), _getterRotation.GetRotation());
    }

}
