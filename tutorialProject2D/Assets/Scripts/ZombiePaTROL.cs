using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePaTROL : MonoBehaviour
{
    public Transform groundCheck;
    bool movingRight = true;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!Physics2D.OverlapCircle(groundCheck.position, 0.1f)) 
        {
            turnPlayer();
            movingRight = !movingRight;

        }
        if (movingRight)
        {
            transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-moveSpeed*Time.deltaTime, 0, 0);
        }

    }

    void turnPlayer()
    {
        Vector3 scale = transform.localScale;
        scale.x = -scale.x;
        transform.localScale = scale;
    }
}
