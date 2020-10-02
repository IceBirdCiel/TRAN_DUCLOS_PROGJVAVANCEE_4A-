using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    private GameData isWinning;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isWinning)
        {
            text.text = "Victoire !";
        }
        else
        {
            text.text = "Défaite !";
        }

    }
}
