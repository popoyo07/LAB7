using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //assume object has collider 
    public GameObject guffin; //reference the pick up 
    public Collider guffinCollider; //reference the pick up's collider, make sure the collider isTrigger
    public Collider playerCollider; //reference the player's collider
    public Renderer guffinRenderer; //reference the mesh renderer of guffin
    void Start()
    {
        guffinCollider = guffin.GetComponent<Collider>();
        guffinRenderer = guffin.GetComponent<Renderer>();
    }

    

    private void OnTriggerEnter(Collider playerCollider)
    {
        Debug.Log("A collision has occured");
        guffinRenderer.enabled = false;
        
    }
}
