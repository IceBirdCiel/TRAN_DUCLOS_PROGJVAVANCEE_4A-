using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CoopScript : MonoBehaviour
{
    [SerializeField]
    private Target StartPoint;

    public Target CurrentTarget;
    public Target OldTarget;

    public NavMeshAgent Agent;
    public bool pursuit;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTarget = StartPoint;

        Agent = this.GetComponent<NavMeshAgent>();
        Agent.destination = CurrentTarget.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pursuit)
        {
            Agent.destination = CurrentTarget.transform.position;
        }
    }

}
