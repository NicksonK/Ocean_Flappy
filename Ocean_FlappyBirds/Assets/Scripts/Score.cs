using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public static int score = 0;
    public int highScore
    {
        get;
        private set;
    }

    public void addScore(int value = 1)
    {

        score += value;

    }

    public void newHighScore()
    {
        highScore = score;
    }

}
