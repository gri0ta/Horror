using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	public float viewDistance;
	public float wanderDistance;
	public float speed;
	public Transform target;

	Rigidbody rb;
	NavMeshAgent agent;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		agent = GetComponent<NavMeshAgent>();
		agent.speed = speed;
	}

	void Update()
	{
		var distance = Vector3.Distance(transform.position, target.position);
		if (distance < viewDistance)
		{
			// SEEK
			agent.destination = target.position;
		}
		else
		{
			// SEARCH
			if (agent.velocity == Vector3.zero)
			{
				var offset = Random.insideUnitSphere * wanderDistance;
				agent.destination = transform.position + offset;
			}
		}

		if (distance < 1f)
		{
			// JUMPSCARE
		}
	}
}