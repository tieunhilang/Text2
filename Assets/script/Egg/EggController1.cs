using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController1 : MonoBehaviour
{

    public float eggSpeed1 = 0.5f;
   


   
    public void Update()
    {
        transform.position -= new Vector3(0, eggSpeed1 * Time.deltaTime, 0);

    }



    
}

