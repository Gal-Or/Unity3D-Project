using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class cupMotion1 : MonoBehaviour
{
    public GameObject theDestination;
    NavMeshAgent theAgent;

    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        theAgent.SetDestination(theDestination.transform.position);
    }
}
