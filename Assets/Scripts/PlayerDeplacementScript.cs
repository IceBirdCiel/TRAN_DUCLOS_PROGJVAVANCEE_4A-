using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeplacementScript : MonoBehaviour
{
    [SerializeField]
    private string FirePlayer;

    [SerializeField]
    private float Speed = 1.0f;

    [SerializeField]
    private string HorizontalName;

    [SerializeField]
    private string VerticalName;

    [SerializeField]
    private LayerMask WallMask;

    private bool pickupKeyPress;
    Vector3 direction = Vector3.zero;

    public bool PickupKeyPress { get => pickupKeyPress; private set => pickupKeyPress = value; }

    CollectibleScript collectible;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw(HorizontalName),0, Input.GetAxisRaw(VerticalName)).normalized;

        gameObject.transform.position += direction * Time.deltaTime * Speed;

        gameObject.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);

        pickupKeyPress = Input.GetAxis(FirePlayer) != 0;

        if(! pickupKeyPress)
        {
            ReleaseCollectible();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if((WallMask.value & (1 << collision.gameObject.layer)) > 0)
        {
            Debug.Log("Collision");
        }
    }

    public void ReleaseCollectible()
    {
        Debug.Log(gameObject + "  " + collectible);
        if(collectible == null)
        {
            return;
        }

        collectible.transform.parent = null;

        collectible = null;
    }

    public void Pickup(CollectibleScript collectible)
    {
        collectible.transform.parent = transform;
    }


}
