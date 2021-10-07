using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScript : MonoBehaviour
{
   

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            var mat = other.gameObject.GetComponent<Renderer>().material; 
            mat.color = Color.blue;
            other.gameObject.GetComponent<Renderer>().material = mat;

            Destroy(other.gameObject);
        }
    }
}
