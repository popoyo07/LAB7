using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //assume object has collider 
    
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("item"))
        {
            Debug.Log("You collected an item");
            Destroy(GameObject.Find("Item"));
        }
        
        
    }
}
