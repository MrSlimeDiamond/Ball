using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Debug.Log("Global Rotation: "+transform.rotation);
        //transform.rotation = Quaternion.identity;
        transform.position = target.position + offset;
    }
}
