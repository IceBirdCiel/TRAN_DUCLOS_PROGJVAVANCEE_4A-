using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    public Target nextTarget;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out CoopScript coop))
        {
            coop.OldTarget = coop.CurrentTarget;
            coop.CurrentTarget = nextTarget;
        }
    }
}
