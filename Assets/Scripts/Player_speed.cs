using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_speed : MonoBehaviour
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
        var v = Input.GetAxis("Vertical") ;
        var h = Input.GetAxis("Horizontal");
        anim.SetFloat("speedv", v);
        anim.SetFloat("speedh", h);


        var v2 = Input.GetAxis("Vertical2");
        var h2 = Input.GetAxis("Horizontal2");
        anim.SetFloat("speedv2", v2);
        anim.SetFloat("speedh2", h2);
    }
}
