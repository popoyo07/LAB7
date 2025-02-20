using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //attach this script to the main camera
    public Transform target; //reference the player
    public Transform CameraObject; //reference the camera
    public int scalar = 1;
    void Start()
    {
        CameraObject.transform.rotation = Quaternion.Euler(45, 0, 0);
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {

        CameraObject.transform.position = target.position + (Vector3.up*scalar) + (Vector3.back*scalar);
        
        
    }
}
