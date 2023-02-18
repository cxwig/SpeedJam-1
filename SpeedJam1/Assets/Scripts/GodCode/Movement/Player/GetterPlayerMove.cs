using System.Collections;
using System;
using UnityEngine;

public class GetterPlayerMove : MonoBehaviour, IGetterMove
{
    [SerializeField] private float _speed;
    [SerializeField] private float _slowlyMovement = 0.5f;
    private ReturnerCurrentSpeed _returnerCurrentSpeed;
    private ReturnerCurrentSpeed _slowlyReturnerSpeed;
    public event Action OnSneak;
    public event Action OnMove;
    public IMove Move { get; private set; }
    public IMove GetMove()
    {
        if(Move == null)
        {
            Move = new PlayerMovement(transform, new ReturnerControllableVector(transform, new ReturnerMultiplySpeeds()));
            _returnerCurrentSpeed = ReturnDeltaSpeed();
            Move.ReturnerVector.ReturnerSpeed.Add(_returnerCurrentSpeed);
        }
        return Move;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _slowlyReturnerSpeed = ReturnDeltaSpeed(_slowlyMovement);
            ReplaceReturnerSpeed(_returnerCurrentSpeed, _slowlyReturnerSpeed);
            OnSneak?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ReplaceReturnerSpeed(_slowlyReturnerSpeed, _returnerCurrentSpeed);
            OnMove?.Invoke();

        }
    }
    private void ReplaceReturnerSpeed(ReturnerCurrentSpeed returnerCurrentSpeed1, ReturnerCurrentSpeed returnerCurrentSpeed2)
    {
        Move.ReturnerVector.ReturnerSpeed.Remove(returnerCurrentSpeed1);
        Move.ReturnerVector.ReturnerSpeed.Add(returnerCurrentSpeed2);

    }
    private ReturnerCurrentSpeed ReturnDeltaSpeed(float factor = 1) => new ReturnerDeltaTimeSpeed(new ReturnerSpeed(_speed * factor));
}
