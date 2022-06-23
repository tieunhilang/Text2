using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController2 : MonoBehaviour
{
    public float eggSpeed2 = 1f;
    


    public void Update()
    {
        transform.position -= new Vector3(0, eggSpeed2 * Time.deltaTime, 0);

    }

    
}
