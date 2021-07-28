using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardPatrolFollow : MonoBehaviour
{
    public PatrolPointsGroup patrolPoints;
    NavMeshAgent agent;
    int pointIndex = -1;
    bool reverse = false;
    [SerializeField] private bool pingPong;

    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        StartWalkingToNextPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (HasAgentArrivedToDestination())
        {
            //Debug.Log("arrived to destination");
            StartWalkingToNextPoint();
        }
    }

    void StartWalkingToNextPoint()
    {
        if (pingPong)
        {
            if (reverse)
            {
                pointIndex--;
                if(pointIndex < 0)
                {
                    reverse = !reverse;
                    StartWalkingToNextPoint();
                    return;
                }
            }
            else
            {
                pointIndex++;
                if(pointIndex >= patrolPoints.points.Count)
                {
                    reverse = !reverse;
                    StartWalkingToNextPoint();
                    return;
                }
            }
        }
        else //loop
        {
            pointIndex++;
            if (pointIndex >= patrolPoints.points.Count)
            {
                pointIndex = 0;
            }
        }
        //Debug.Log("Next Point Index: " + pointIndex);
        agent.SetDestination(patrolPoints.points[pointIndex].positionOnFloor);
    }

    bool HasAgentArrivedToDestination()
    {
        bool hasArrived = false;
        // Check if we've reached the destination
        //if (!agent.pathPending)
        //{
        //    if (agent.remainingDistance <= agent.stoppingDistance)
        //    {
        //        if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
        //        {
        //            // Done
        //            hasArrived = true;
        //        }
        //    }
        //}

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            // Done
            hasArrived = true;
        }

        return hasArrived;
    }
}
