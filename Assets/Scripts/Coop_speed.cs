using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coop_speed : MonoBehaviour
{

    [SerializeField]
    private CoopScript script;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var v = script.Agent.velocity.x;
        var h = script.Agent.velocity.z;
        anim.SetFloat("speedvPolice", v);
        anim.SetFloat("speedhPolice", h);
    }
}
