using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcingObject : MonoBehaviour
{

    public Rigidbody rb;

    void Start()
    {
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
