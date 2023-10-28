using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public ScoreScript Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score.keepingScore();
    }
}
