using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -6f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        
        if(this.transform.position.z < lowerBound)
        {
            
            Destroy(gameObject);
 
        }
        
    }
}
