using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float myTimer = 0;
    public float fullHeight = 15;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(myTimer < spawnRate)
        {
            myTimer = myTimer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            myTimer = 0;
           
        }
        
        
      
    }
    void spawnPipe()
    {
        float highestPoint = transform.position.y - fullHeight;
        float lowestPoint  = transform.position.y + fullHeight;
        Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
       
        
    }
}
