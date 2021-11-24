using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_paint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        global.paint_color = true;
        Debug.Log(global.paint_color);
    }
}
