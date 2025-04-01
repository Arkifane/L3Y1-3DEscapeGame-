using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent agent;
    FieldOfView fovScript;
    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        fovScript = transform.GetComponent<FieldOfView>();
        agent = transform.GetComponent<NavMeshAgent>();
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (fovScript.canSeePlayer)
        {
            targetPosition = fovScript.playerRef.transform.position;
        }

        agent.destination = targetPosition;
    }
}
