using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(GetterPlayerMove))]
public class SetterSneakingMove : MonoBehaviour
{
    [SerializeField] private ChangerPlayerState _changerPlayerState;
    [SerializeField] private float _slowlyMovement = 0.5f;
    private GetterPlayerMove _getterMove;
    private ReturnerCurrentSpeed _slowlyReturnerSpeed;
    public bool IsSneaking { get; private set; }
    private void Awake()
    {
        _changerPlayerState.OnSneak += Sneak;
        _changerPlayerState.OnMove += Move;
        _getterMove = GetComponent<GetterPlayerMove>();
    }
    private void Sneak()
    {
        IsSneaking = true;
        _slowlyReturnerSpeed = _getterMove.ReturnDeltaSpeed(_slowlyMovement);
        _getterMove.Move.ReturnerVector.ReturnerSpeed.Add(_slowlyReturnerSpeed);
        //ReplaceReturnerSpeed(_getterMove.ReturnerCurrentSpeed, _slowlyReturnerSpeed);
    }
    private void Move()
    {
        IsSneaking = false;
        Debug.Log(" YOU HERE " + _slowlyReturnerSpeed + " ? " + _getterMove.ReturnerCurrentSpeed);
        _getterMove.Move.ReturnerVector.ReturnerSpeed.Remove(_slowlyReturnerSpeed);
        // ReplaceReturnerSpeed(_slowlyReturnerSpeed, _getterMove.ReturnerCurrentSpeed);
    }
    private void Update()
    {
        Debug.LogError(IsSneaking + " YEAH!");
    }
    private void OnDisable()
    {
        _changerPlayerState.OnSneak -= Sneak;
        _changerPlayerState.OnMove -= Move;
    }
    private void ReplaceReturnerSpeed(ReturnerCurrentSpeed returnerCurrentSpeed1, ReturnerCurrentSpeed returnerCurrentSpeed2)
    {
        _getterMove.Move.ReturnerVector.ReturnerSpeed.Remove(returnerCurrentSpeed1);
        _getterMove.Move.ReturnerVector.ReturnerSpeed.Add(returnerCurrentSpeed2);

    }
}
