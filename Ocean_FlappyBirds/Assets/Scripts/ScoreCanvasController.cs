using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCanvasController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();
        
    }
}
