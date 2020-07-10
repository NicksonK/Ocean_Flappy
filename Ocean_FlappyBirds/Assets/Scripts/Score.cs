using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public static int score = 0;
    public static int highScore = PlayerPrefs.GetInt("HighScore");

}
