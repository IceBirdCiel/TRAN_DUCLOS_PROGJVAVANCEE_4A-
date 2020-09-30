using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeplacementScript : MonoBehaviour
{
    [SerializeField]
    private float Speed = 1;

    [SerializeField]
    private string HorizontalName;

    [SerializeField]
    private string VerticalName;

    [SerializeField]
    private LayerMask WallMask;

    Vector3 direction = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw(HorizontalName),0, Input.GetAxisRaw(VerticalName)).normalized;

        gameObject.transform.position += direction * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if((WallMask.value & (1 << collision.gameObject.layer)) > 0)
        {
            Debug.Log("Collision");
        }
    }


}
