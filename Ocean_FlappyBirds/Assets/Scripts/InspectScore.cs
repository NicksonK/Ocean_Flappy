using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Text))]
public class InspectScore : MonoBehaviour
{
    public enum Properties
    {
        score,
        highScore
    }

    public Properties observate;
    public bool realTime = false;

    // Start is called before the first frame update
    void Start()
    {

        switch (observate)
        {
            case Properties.score:

                GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();
                break;

            case Properties.highScore:

                GetComponent<UnityEngine.UI.Text>().text = Score.highScore.ToString();
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (observate)
        {
            case Properties.score:

                GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();
                break;

            case Properties.highScore:

                GetComponent<UnityEngine.UI.Text>().text = Score.highScore.ToString();
                break;
        }

    }
}
