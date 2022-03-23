using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    Rigidbody rb;
    // Update is called once per frame
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //Jump
        {
            rb.AddForce(Vector3.up * 200);
        }
        rb.velocity = Vector3.forward * 10f;
    }
}
