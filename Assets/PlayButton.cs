using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    GameObject button;
    public bool playing = false;
    
    public void OnButtonPress() {
      Debug.Log("play button press");
      button.SetActive(false);
      rb.useGravity = true;
      playing = true;
   }
    void Start()
    {
        Debug.Log("Test");
        button = GameObject.Find("play");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
