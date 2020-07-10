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

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "DeadZone")
        {

            Time.timeScale = 0;
            rig.simulated = false;

        }

    }

}
