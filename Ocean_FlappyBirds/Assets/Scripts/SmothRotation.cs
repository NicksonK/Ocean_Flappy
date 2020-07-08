using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SmothRotation : MonoBehaviour
{

    public float tiltSmoth = 1;

    public Vector3 downAngle;
    public Vector3 upAngle;

    Quaternion downRotation;
    Quaternion upRotation;

    Rigidbody2D rig;

    private void Start()
    {

        rig = GetComponent<Rigidbody2D>();

        downRotation = Quaternion.Euler(downAngle);
        upRotation = Quaternion.Euler(upAngle);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (rig.simulated)
        {

            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmoth * Time.deltaTime);

        }
        
    }

    public void upAnimation()
    {

        transform.rotation = upRotation;

    }

}
