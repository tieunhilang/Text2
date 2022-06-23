using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScore2 : MonoBehaviour
{
    private BucketController2 bucket;

    public void OnTriggerEnter(Collider egg)
    {
        bucket = transform.parent.GetComponent<BucketController2>();
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
        if (egg.tag == "Egg4")
        {

            bucket.addScore(4);

            Destroy(egg.gameObject);
        }
        if (egg.tag == "Egg5")
        {

            bucket.addScore(5);

            Destroy(egg.gameObject);
        }

    }
}