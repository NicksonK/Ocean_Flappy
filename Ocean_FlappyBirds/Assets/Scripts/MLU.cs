using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MLU : MonoBehaviour
{

    public float velocity = 1;

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * Time.deltaTime * velocity;

    }

}
