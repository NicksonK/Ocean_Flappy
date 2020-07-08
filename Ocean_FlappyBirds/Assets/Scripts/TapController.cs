using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class TapController : MonoBehaviour
{
    public float force = 200;
    public Vector3 startPosition;

    Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {

        rig = GetComponent<Rigidbody2D>();
        rig.transform.position = startPosition;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            rig.AddForce(Vector2.up * force, ForceMode2D.Force);

            GetComponent<SmothRotation>().upAnimation();

        }
        
    }

}