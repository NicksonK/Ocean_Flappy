using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float velocity = 0;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {

        startPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * velocity * Time.deltaTime;

        Vector3 currentPosition = transform.position;

        if (currentPosition.x <= startPosition.x * -1)
        {

            transform.position = new Vector3(currentPosition.x * -1, currentPosition.y, currentPosition.z);

        }
        
    }
}
