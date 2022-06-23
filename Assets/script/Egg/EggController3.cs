using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController3 : MonoBehaviour
{
    public float eggSpeed3 = 1.5f;
    


    public void Update()
    {
        transform.position -= new Vector3(0, eggSpeed3 * Time.deltaTime, 0);

    }



    
}
