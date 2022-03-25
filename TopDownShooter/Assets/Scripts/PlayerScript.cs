using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    Vector3 mousePos;
    Vector2 direction;

    public GameObject bullet;
    public Transform shootStartPos;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - transform.position;
        transform.right = direction; //cannon points to positive x at the beginning

        if (Input.GetMouseButtonDown(0))
        {
            shootbullet();
        }
    }
    void shootbullet()
    {
        Instantiate(bullet, shootStartPos.position, transform.rotation);
    }
}
