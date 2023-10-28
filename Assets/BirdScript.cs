using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float jumpStrength = 0;
    public RestartingGameScript restartingGameScript;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true)
        {
            myRigidBody.velocity = Vector2.up * jumpStrength;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        restartingGameScript.gameOver();
        birdIsAlive = false;
    }
}
