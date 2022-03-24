using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    Rigidbody rb;
    Vector3 moveInput;

    Vector3 mousePos;
    Vector3 direction;
    Vector3 playerPos;
    public float gravity = -9.81f;
    public float speed = 3f;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            rb.velocity = Vector3.up * 100;
        }

        mousePos = Input.mousePosition;
        playerPos = Camera.main.WorldToScreenPoint(transform.position);

        direction = mousePos - playerPos;

        float rotAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(-rotAngle, Vector3.up);

    }

    private void FixedUpdate()
    {
        moveInput.x = Input.GetAxis("Horizontal") * speed;
        moveInput.z = Input.GetAxis("Vertical") * speed;

        if(!controller.isGrounded)
        {
            moveInput.y += gravity;
        }
        controller.Move(moveInput);
    }
}
