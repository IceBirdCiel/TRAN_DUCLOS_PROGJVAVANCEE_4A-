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

    private NavMeshAgent Agent;

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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Target target))
        {
            this.OldTarget = this.CurrentTarget;
            this.CurrentTarget = target.nextTarget;
        }
    }
}
