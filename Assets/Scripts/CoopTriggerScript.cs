using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoopTriggerScript : MonoBehaviour
{
    [SerializeField]
    public CoopScript coop;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerDeplacementScript player))
        {
            coop.pursuit = true;
            coop.Agent.destination = other.gameObject.transform.position;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerDeplacementScript player))
        {
            coop.pursuit = true;
            coop.Agent.destination = other.gameObject.transform.position;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerDeplacementScript player))
        {
            coop.pursuit = false;
            coop.Agent.destination = coop.OldTarget.transform.position;
        }
    }
}
