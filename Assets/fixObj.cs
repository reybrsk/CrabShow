using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixObj : MonoBehaviour
{

    private Animator animator;
    private bool fix = false;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInParent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetBool("fix"))
        {
            fix = true;
        }
        

    }

    private void OnTriggerStay(Collider other)
    {
        if (fix && other.gameObject.CompareTag("Object"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
            other.gameObject.AddComponent<FixedJoint>();
            FixedJoint springJoint = other.gameObject.GetComponent<FixedJoint>();
            springJoint.connectedBody = this.gameObject.GetComponent<Rigidbody>();
            

        }
    }
}
