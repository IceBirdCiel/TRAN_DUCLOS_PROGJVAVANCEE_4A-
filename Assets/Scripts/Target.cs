using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    public Target nextTarget;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(transform.name);
        Debug.Log(other.transform.name);
        if (other.gameObject.TryGetComponent(out CoopScript coop))
        {
            coop.SetNextStep(nextTarget);
        }
    }
}
