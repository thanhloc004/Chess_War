using Sirenix.OdinInspector;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [Title("References")]
    [SerializeField] private EntityTurn entityTurn;


    public void CalculatorDirection()
    {
        if (entityTurn.CanMoveInDirection(transform.forward))
        {
            entityTurn.Rotation(transform.forward);
        }
        else
        {
            entityTurn.Rotation(-transform.forward);
        }
    }
}
