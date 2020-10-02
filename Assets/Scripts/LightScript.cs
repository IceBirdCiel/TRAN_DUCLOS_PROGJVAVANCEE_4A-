using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    [SerializeField]
    private Light light;

    private Color color;

    private float time;
    private int x;

    private void Start()
    {
        time = 1;
        x = 0;
        light.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime*4.0f;
        x = (int)time;

        Debug.Log(x);
        if((x/2)%2 == 0)
        {
            color = Color.red;
        }
        else
        {
            color = Color.blue;
        }

        light.color = color;
    }
}
