using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody rb;


    void Start()
    {   
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rb.velocity);
    }
}
