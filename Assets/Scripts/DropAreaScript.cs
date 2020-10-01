using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAreaScript : MonoBehaviour
{
    [SerializeField]
    private ScoreTextScript score;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        if(collision.gameObject.TryGetComponent(out CollectibleScript collectible))
        {
            Destroy(collectible.gameObject);
            score.score.AugmenterScore(collectible.value);
        }
    }
}
