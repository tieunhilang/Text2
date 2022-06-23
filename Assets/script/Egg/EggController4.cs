using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController4 : MonoBehaviour
{
    public float eggSpeed3 = 1.75f;



    public void Update()
    {
        transform.position -= new Vector3(0, eggSpeed3 * Time.deltaTime, 0);

    }




}
