using System.Collections.Generic;

using UnityEngine;

using UnityEngine.AI;
 
public class WaypointAI : MonoBehaviour

{

    public List<Transform> wayPoint;

    NavMeshAgent navMeshAgent;

    FieldOfView fovScript;

    Vector3 targetPosition;
 
    public int currentWayPointIndex = 0;
 
    // Start is called before the first frame update

    void Start()

    {

        navMeshAgent = GetComponent<NavMeshAgent>();

        fovScript = transform.GetComponent<FieldOfView>();

        targetPosition = transform.position;

    }
 
    // Update is called once per frame

    void Update()

    {

        Walking();

    }
 
    void Walking()

    {

        if (wayPoint.Count == 0)

        {

            return;

        }
 
        // Check distance to current waypoint

        float distanceToWayPoint = Vector3.Distance(wayPoint[currentWayPointIndex].position, transform.position);
 
        // If the waypoint is close, move to the next one

        if (distanceToWayPoint <= 3)

        {

            currentWayPointIndex = (currentWayPointIndex + 1) % wayPoint.Count;

        }
 
        // Set the destination to the current waypoint

        navMeshAgent.SetDestination(wayPoint[currentWayPointIndex].position);
 
        // If the player is within view, set the destination to the player's position

        if (fovScript.canSeePlayer)

        {

            targetPosition = fovScript.playerRef.transform.position;

            navMeshAgent.SetDestination(targetPosition); // Update the destination to the player's position

        }

    }

}

 