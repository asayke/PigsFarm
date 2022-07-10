using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private Camera mainCamera;
    private NavMeshAgent agent;

    private void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        //agent.SetDestination(new Vector3(6,0.37f,0));
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            RaycastHit2D hit = Physics2D.Raycast(mainCamera.transform.position, mainCamera.ScreenToWorldPoint(Input.mousePosition));
            print(Input.mousePosition);
            agent.SetDestination(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    private void LateUpdate()
    {
        // if (agent.velocity.sqrMagnitude > Mathf.Epsilon)
        // {
        //     transform.rotation = Quaternion.LookRotation(agent.velocity.normalized);
        // }

        transform.rotation = Quaternion.identity;
    }
}
