using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CollidersInterations : MonoBehaviour
{

    Rigidbody2D rig;

    private void Start()
    {

        rig = GetComponent<Rigidbody2D>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "PointZone")
        {

            Debug.Log("Point");

        }

        if (collision.gameObject.tag == "DeadZone")
        {
            Debug.Log("dead");

            rig.simulated = false;

        }
    }

}
