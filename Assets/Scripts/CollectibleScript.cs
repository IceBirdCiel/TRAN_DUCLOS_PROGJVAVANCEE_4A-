using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    [SerializeField]
    public int value;

    private void OnCollisionEnter(Collision collision)
    {
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
        if (collision.gameObject.TryGetComponent(out PlayerDeplacementScript player))
        {
            if (player.PickupKeyPress)
            {
                player.Pickup(this);
            }
        }
    }
}
