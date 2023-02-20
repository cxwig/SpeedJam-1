using UnityEngine;

public class ReturnerEnemyRotation : IReturnerRotation
{
    private readonly float _offset;
    private readonly Transform _self;
    private readonly Transform _target;
    private readonly float _startX;
    public ReturnerEnemyRotation(Transform self, float startX, Transform target)
    {
        _startX = startX;
        _self = self;
        _target = target;
    }

    public Vector3 ReturnRotation()
    {
        bool isTargerRighter = _self.transform.position.x < _target.transform.position.x;
        float x = _startX * isTargerRighter.NegativityByCondition();
        Debug.Log("POP " + isTargerRighter);
        return new Vector2(x, _self.localScale.y);
    }
}