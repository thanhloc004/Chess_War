using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Title("Component")]
    [SerializeField] private HealthComponent health;

    private Animator animator;
    private readonly int IdleHash = Animator.StringToHash("Idle");
    private readonly int MoveHash = Animator.StringToHash("Move");
    private readonly int AttackHash = Animator.StringToHash("Attack");
    private const float CrossFadeDuration = 0.1f;



    private bool enableControl;

    //Entity parametor
    private Vector3 direction;
    private Transform mainTransform;

    //MonoBehaviour Method
    private void Awake()
    {
        animator = GetComponent<Animator>();

        //Get Cls Component
        health = GetComponent<HealthComponent>();
    }

    private void Start()
    {
        mainTransform = transform;

        //RegesterListener
        health.OnDeath += HandleDeathEvent;
    }

    //Events
    private void HandleDeathEvent()
    {
    }

}
