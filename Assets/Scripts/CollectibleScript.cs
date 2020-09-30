using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    [SerializeField]
    private string FirePlayer;
    
    [SerializeField]
    private string FirePlayer2;

    private bool pickupKeyPress;
    private bool pickupKeyPress2;

    
    // Update is called once per frame
    void Update()
    {
        pickupKeyPress = Input.GetAxis(FirePlayer) != 0;
        pickupKeyPress2 = Input.GetAxis(FirePlayer2) != 0;

        if (!pickupKeyPress&!pickupKeyPress2)
        {
            transform.parent = null;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out PlayerDeplacementScript player))
        {
            if(pickupKeyPress)
                this.transform.parent = collision.gameObject.transform;
            else if (pickupKeyPress2)
                this.transform.parent = collision.gameObject.transform;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerDeplacementScript player))
        {
            if (pickupKeyPress)
                this.transform.parent = collision.gameObject.transform;
            else if (pickupKeyPress2)
                    this.transform.parent = collision.gameObject.transform;
        }
    }
}
