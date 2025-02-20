using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 a = new Vector3(horizontal, 0, 0);
        Vector3 b = new Vector3(0, 0, vertical);
        transform.Translate(a*speed*Time.deltaTime);
        transform.Translate(b*speed*Time.deltaTime);
    }
}
