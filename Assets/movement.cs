using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    PlayButton playButton;
    Rigidbody rb;
    /*
     * TODO
     * Float for Speed; idea: more speed as the game progresses
    */
    public float moveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(0, 10, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown("a")) {
            if (playButton.playing == true) {
                Debug.Log("Playing");
            } else {
                Debug.Log("Not playing");
            }
        }
        
    }
}