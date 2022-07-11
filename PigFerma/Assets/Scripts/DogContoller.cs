using System;
using UnityEngine;
using UnityEngine.AI;

public class DogContoller : MonoBehaviour
{
    private Camera mainCamera;
    private NavMeshAgent agent;
    private Transform pig;

    private void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        pig = FindObjectOfType<PlayerController>().transform;
    }

    private void Update()
    {
        agent.SetDestination(pig.position);
    }
    
    private void LateUpdate()
    {
        transform.rotation = Quaternion.identity;
    }
    
}