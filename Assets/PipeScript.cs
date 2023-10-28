using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float pipeMovementSpeed = 0;
    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeMovementSpeed) * Time.deltaTime;
        if (transform.position.x < -40)
        {
            Destroy(pipe);
        }
    }
}
