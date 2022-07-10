using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FarmerController : MonoBehaviour
{
    private Camera mainCamera;
    private NavMeshAgent agent;
    private System.Random random;

    private void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        random = new System.Random();
    }

    private void Update()
    {
        if (agent.velocity.magnitude <= Mathf.Epsilon)
        {
            Vector2 randomPoint = new Vector2(random.Next(0, Screen.width), random.Next(0, Screen.height));
            agent.SetDestination(mainCamera.ScreenToWorldPoint(randomPoint));
            
        }

        
        
    }

    private void LateUpdate()
    {
        transform.rotation = Quaternion.identity;
    }
}
