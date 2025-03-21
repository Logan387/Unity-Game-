using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    NavMeshAgent ai;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ai.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        ai = GetComponent<NavMeshAgent>();
        ai.destination = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
