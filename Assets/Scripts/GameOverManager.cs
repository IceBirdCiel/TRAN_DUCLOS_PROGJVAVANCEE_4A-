using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [SerializeField]
    private Animator fox1, fox2;
    [SerializeField]
    private GameData gameData;

    // Start is called before the first frame update
    void Start()
    {
        fox1.SetBool("IsWinning", gameData.IsWinning);
        fox2.SetBool("IsWinning", gameData.IsWinning);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
