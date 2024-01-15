using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class EntityTurn : MonoBehaviour
{
    [Title("Config")]
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private float rotationSmoothTime = 0.5f;
    [SerializeField] private float maxDistance = 1.0f;
    [SerializeField] private LayerMask obstacleMask;
    [SerializeField] private LayerMask groundMask;

    public Transform mainTransform { get ; set ; }

    private Vector3 direction;

    private void Awake()
    {
        mainTransform = transform;
    }

    public void Rotation(Vector3 dir)
    {
        direction = dir.ConvertDirectionToVector3();

        if (CanMoveInDirection(direction))
        {
            if (direction != transform.forward)
            {
                mainTransform.DORotateQuaternion(Quaternion.LookRotation(direction, Vector3.up), rotationSmoothTime)
                    .OnComplete(Move);
            }
            else
            {
                Move();
            }
        }
        else
        {

        }
    }

    public void Move()
    {
        Vector3 destination = ConvertToRoundedWorld((GetPosition() + mainTransform.forward));

        mainTransform.DOMove(destination, speed)
            .OnComplete(() =>
            {
                Attack();
                DOTween.Kill(mainTransform);
            });
    }

    public void Attack()
    {
    }


    //Check
    public bool CanMoveInDirection(Vector3 direction)
    {
        if (DirectionCheck(direction) && GroundCheck(GetPosition() + direction))
        {
            return true;
        }
        return false;
    }

    private bool DirectionCheck(Vector3 direction)
    {
        return Physics.Raycast(mainTransform.position + Vector3.up * 0.5f, direction, 0.5f, obstacleMask) ? false : true;
    }

    private bool GroundCheck(Vector3 origin)
    {
        return Physics.Raycast(origin + Vector3.up * 0.5f, Vector3.down, maxDistance, groundMask);
    }

    private Vector3 GetPosition() => mainTransform.position;
    private Vector3Int ConvertToRoundedWorld(Vector3 position)
    {
        int x = Mathf.RoundToInt(position.x);
        int y = Mathf.RoundToInt(position.y);
        int z = Mathf.RoundToInt(position.z);

        return new Vector3Int(x, y, z);
    }
}