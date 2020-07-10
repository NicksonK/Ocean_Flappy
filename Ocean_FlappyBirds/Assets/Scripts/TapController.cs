using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class TapController : MonoBehaviour
{

    private void OnEnable()
    {
        CanvasController.gameStart += setPlayerPosition;   
    }

    private void OnDisable()
    {

        CanvasController.gameStart -= setPlayerPosition;

    }

    public float force = 200;
    public Vector3 startPosition;

    Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {

        rig = GetComponent<Rigidbody2D>();
        rig.velocity = Vector3.zero;
        rig.transform.position = startPosition;
        rig.simulated = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!CanvasController.onGame) return;

        if (Input.GetMouseButtonDown(0))
        {

            rig.AddForce(Vector2.up * force, ForceMode2D.Force);

            GetComponent<SmothRotation>().upAnimation();

        }
        
    }

    void setPlayerPosition()
    {

        rig.velocity = Vector3.zero;
        rig.transform.position = startPosition;
        rig.simulated = true;

    }


}