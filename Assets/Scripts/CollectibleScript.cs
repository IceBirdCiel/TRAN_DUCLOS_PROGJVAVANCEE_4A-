using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    [SerializeField]
    public int value;

    private bool picked;
    private void Update()
    {
        picked = false;

        if (picked)
        {
            //this.GetComponent(boxcollider);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        if(collision.gameObject.TryGetComponent(out PlayerDeplacementScript player))
        {
            if(player.PickupKeyPress)
            {
                player.Pickup(this);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.TryGetComponent(out PlayerDeplacementScript player))
        {
            if (player.PickupKeyPress)
            {
                player.Pickup(this);
            }
        }
    }
}
