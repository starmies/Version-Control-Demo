using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Martijn : MonoBehaviour
{


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name=="A")
        {
            Instantiate(gameObject);
        }
        else if (col.gameObject.tag == "cube")
        {
            Instantiate(gameObject);
        }
    }
}
