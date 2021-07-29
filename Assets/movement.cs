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
    public float moveSpeed = 3.0f;
    public PlayButton playButton; // C# why???
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playButton = gameObject.GetComponent<PlayButton>();
        //rb.velocity = new Vector3(0, 10, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown("a")) {
            if (playButton.playing) {
                // move left
                gameObject.transform.position = new Vector3(
                    gameObject.transform.position.x - 0.3f, 
                    gameObject.transform.position.y, 
                    gameObject.transform.position.z
                );
                
            } else {
                // do nothing
            }
        }
        if (Input.GetKeyDown("d")) {
            if (playButton.playing) {
                gameObject.transform.position = new Vector3(
                    gameObject.transform.position.x + 0.3f, 
                    gameObject.transform.position.y, 
                    gameObject.transform.position.z
                );
                
            } else {
                // do nothing
            }
        }
        
    }
}