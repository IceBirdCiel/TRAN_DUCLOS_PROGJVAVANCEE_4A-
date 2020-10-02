using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMesh;

    public float timeleft;

    // Update is called once per frame
    void Update()
    {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            textMesh.text = "Time :" + timeleft.ToString("0");
        }
    }
}
