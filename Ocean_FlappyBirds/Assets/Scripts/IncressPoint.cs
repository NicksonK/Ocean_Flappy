using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncressPoint : MonoBehaviour
{
    public delegate void IncressPointDelegate();
    public static event IncressPointDelegate incressPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        incressPoint();
        Score.score++;
        
    }
}
