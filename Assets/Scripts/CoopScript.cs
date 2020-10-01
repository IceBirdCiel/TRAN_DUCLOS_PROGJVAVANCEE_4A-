using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoopScript : MonoBehaviour
{
    private float Speed;
    Vector3 direction = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(1, 0, 1).normalized;

        gameObject.transform.position += direction * Time.deltaTime * Speed;

        gameObject.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
