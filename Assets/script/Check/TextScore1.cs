using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScore1 : MonoBehaviour
{
    private BucketController1 bucket1;

    public void OnTriggerEnter(Collider egg1)
    {
        bucket1 = transform.parent.GetComponent<BucketController1>();
        if (egg1.tag == "Egg1")
        {

            bucket1.addScore(1);

            Destroy(egg1.gameObject);
        }

        if (egg1.tag == "Egg2")
        {

            bucket1.addScore(2);

            Destroy(egg1.gameObject);
        }


        if (egg1.tag == "Egg3")
        {

            bucket1.addScore(3);

            Destroy(egg1.gameObject);
        }
        if (egg1.tag == "Egg4")
        {

            bucket1.addScore(4);

            Destroy(egg1.gameObject);
        }
     

    }
}
