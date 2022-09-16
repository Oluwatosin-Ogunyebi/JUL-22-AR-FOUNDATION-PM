using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NPCNavMesh : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent npcAgent;

    public List<Transform> targets;
    private int currentTarget;

    public bool varyingTargets = false;

    private void Awake()
    {
        npcAgent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //npcAgent.destination = target.position;
        SetWayPoint();
    }

    void SetWayPoint()
    {
        if (targets.Count == 0)
        {
            Debug.Log("Target Positions are empty, please add at least one target position");
            return;
        }

        if (Vector3.Distance(targets[currentTarget].position, transform.position) < 0.1f)
        {
            if (varyingTargets)
            {
                currentTarget = Random.Range(0, targets.Count);
            }
            else
            {
                currentTarget++;
            }
            
            if (currentTarget >= targets.Count)
            {
                currentTarget = 0;
            }
        }

        npcAgent.SetDestination(targets[currentTarget].position);
    }
}
