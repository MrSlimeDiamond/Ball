using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayButton))]
public class movement : MonoBehaviour
{
    /*
     * TODO
     * Float for Speed; idea: more speed as the game progresses
    */

    public Rigidbody rb;
    public float moveSpeed { get; private set; }
    public PlayButton playButton; // C# why???
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playButton = gameObject.GetComponent<PlayButton>();
        moveSpeed = 0.1f;
        //rb.velocity = new Vector3(0, 10, 0);
    }

    void Update()
    {
        if (Input.GetKey("a")) {
            if (playButton.playing) {
                // move left
                gameObject.transform.position = new Vector3(
                    gameObject.transform.position.x - moveSpeed, 
                    gameObject.transform.position.y, 
                    gameObject.transform.position.z
                );
                
            } else {
                // do nothing
            }
        }
        if (Input.GetKey("d")) {
            if (playButton.playing) {
                gameObject.transform.position = new Vector3(
                    gameObject.transform.position.x + moveSpeed, 
                    gameObject.transform.position.y, 
                    gameObject.transform.position.z
                );
                
            } else {
                // do nothing
            }
        }
        
    }
}