using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMove : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    public GameObject lose;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target!=null)
        {

            agent.SetDestination(target.position);
            if (Vector3.Distance(transform.position,target.position)<5f)
            {
                Destroy(target.gameObject);
                lose.SetActive(true);
            }
        }

    }
}
