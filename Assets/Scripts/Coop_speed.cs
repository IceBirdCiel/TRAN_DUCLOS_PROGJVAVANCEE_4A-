using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coop_speed : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");
        anim.SetFloat("speedvPolice", v);
        anim.SetFloat("speedhPolice", h);
    }
}
