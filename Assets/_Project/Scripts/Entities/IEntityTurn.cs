using UnityEngine;

public interface IEntityTurn
{
    Transform Transform { get; set; }

    void Rotation(Vector3 dir);
    void Move();
    void Attack();
}
