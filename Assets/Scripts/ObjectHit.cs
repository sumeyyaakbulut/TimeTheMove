using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {

            GetComponent<MeshRenderer>().material.color = Color.magenta;
            gameObject.tag = "Hit";
        }
        
    }
}
