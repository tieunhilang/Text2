using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCore : MonoBehaviour
{
    private BucketController bucket;

    public void OnTriggerEnter(Collider egg)
    {
        bucket = transform.parent.GetComponent<BucketController>();
        if (egg.tag == "Egg1")
        {

            bucket.addScore(1);
     
            Destroy(egg.gameObject);
        }
        
        if (egg.tag == "Egg2")
        {

            bucket.addScore(2);

            Destroy(egg.gameObject);
        }
        
        
        if (egg.tag == "Egg3")
        {

            bucket.addScore(3);

            Destroy(egg.gameObject);
        }
      
        
    }
}
