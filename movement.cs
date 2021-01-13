using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // movementForce();
        if (!coll.isFinished)
        {
            movementTranslate();
        }
    }

    private void movementTranslate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(new Vector3(0, 0, 1*speed),Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(new Vector3(0, 0, -1*speed), Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(new Vector3(-1*speed, 0, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(new Vector3(1*speed, 0, 0), Space.World);
        }
    }

    private void movementForce()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, 1 * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -1 * speed, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-1 * speed, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(1 * speed, 0, 0, ForceMode.VelocityChange);
        }
    }
}
