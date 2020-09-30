using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAreaScript : MonoBehaviour
{
    private bool drop;

    // Start is called before the first frame update
    void Start()
    {
        drop = false;

        if (drop)
        {
            //Delete(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out CollectibleScript collectible))
        {

        }
    }
}
