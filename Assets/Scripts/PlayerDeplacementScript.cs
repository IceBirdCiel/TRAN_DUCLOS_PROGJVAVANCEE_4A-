﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerDeplacementScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource audio;

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

    [SerializeField]
    public ScoreTextScript score;

    [SerializeField]
    private GameObject spawn;

    Vector3 direction = Vector3.zero;

    private bool isCaptured;
    public bool PickupKeyPress { get; private set; }

    CollectibleScript collectible;

    // Update is called once per frame
    void Update()
    {
        isCaptured = false;

        direction = new Vector3(Input.GetAxisRaw(HorizontalName),0, Input.GetAxisRaw(VerticalName)).normalized;

        gameObject.transform.position += direction * Time.deltaTime * Speed;

        if(direction != Vector3.zero)
        {
            gameObject.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }

        PickupKeyPress = Input.GetAxis(FirePlayer) != 0;

        if(!PickupKeyPress)
        {
            ReleaseCollectible();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out CoopScript coop))
        {
            audio.Play();
            this.transform.position = spawn.transform.position;
            score.score.AugmenterScore(-75);
            isCaptured = true;
        }
    }

    public void ReleaseCollectible()
    { 
        if(collectible == null)
        {
            return;
        }
        collectible.transform.parent = null;
        collectible = null;
    }

    public void Pickup(CollectibleScript collectible)
    {
        this.collectible = collectible;
        collectible.transform.parent = transform;
        PickupKeyPress = true;
    }


}
