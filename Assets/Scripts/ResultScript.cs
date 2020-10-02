using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private GameData isWinning;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(isWinning.IsWinning);
        if (!isWinning.IsWinning)
        {
            text.text = "Défaite !";
        }
        else
        {
            text.text = "Victoire !";
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
