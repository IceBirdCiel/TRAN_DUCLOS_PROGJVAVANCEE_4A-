using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMesh;
    public Score score;
    
    void Start()
    {
        score = new Score();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "Score : " + score.score.ToString();
    }
}
