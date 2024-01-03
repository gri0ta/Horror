using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    public float wanderDistance = 2;
    public int wanderChance = 100;
    public float viewRange = 10;
    Rigidbody rb;
    NavMeshAgent agent;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (target == null)
        {
            animator.Play("Idle");
        }
        else
        {
            animator.Play("Walk");
        }

        if (target == null) return;

        agent.speed = speed;

        var distance = Vector3.Distance(transform.position, target.position);

        if (distance < viewRange)
        {
            // SEEK
            agent.destination = target.position;
        }
        else
        {
            // WANDER
            if (Random.Range(0, wanderChance) == 1)
            {
                var offset = Random.insideUnitSphere * wanderDistance;
                agent.destination = transform.position + offset;
            }
        }

        if (distance < 1f)
        {
            // RESTART
        }
    }
}