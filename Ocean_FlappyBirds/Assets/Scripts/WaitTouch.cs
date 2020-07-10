using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTouch : MonoBehaviour
{
    public delegate void TouchScreen();
    public static event TouchScreen touch;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            touch();
        }
        
    }
}
