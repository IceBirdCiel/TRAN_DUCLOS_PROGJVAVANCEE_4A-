using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CoopScript : MonoBehaviour
{
    [SerializeField]
    private Target StartPoint;

    [SerializeField]
    public ScoreTextScript score;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerDeplacementScript player)){
            Destroy(player);
            score.score.AugmenterScore(-75);
            //Instantiate();
        }
    }
}
