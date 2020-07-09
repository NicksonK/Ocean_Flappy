using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float timeGap;
    private float timer;
    public GameObject obstacle;

    public float range;

    private void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (timer >= timeGap)
        {
            Vector3 randonPosition = transform.position + new Vector3(0, Random.Range(-range, range), 0);
            GameObject finger = Instantiate(obstacle,randonPosition ,Quaternion.identity, transform);
            Destroy(finger, 4 * timeGap);

            timer = 0;

        }

        timer += Time.deltaTime;
        
    }
}
