using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int Score;
    public Text scoreText;

    public void keepingScore()
    {
        Score = Score + 1;
        scoreText.text = Score.ToString();

    }
}
