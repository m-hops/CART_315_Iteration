using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterNavMeshControl : MonoBehaviour
{

    [SerializeField] private Transform movePositionTransoform;

    private NavMeshAgent navMeshAgent;

   private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navMeshAgent.destination = movePositionTransoform.position;
    }
}
