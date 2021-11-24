using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paint_dog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D( )
    {
        Debug.Log("b");
        if(Input.GetKeyDown(KeyCode.Z) && global.paint_color == true)
        {
            Debug.Log("a");
        }
    }
}
