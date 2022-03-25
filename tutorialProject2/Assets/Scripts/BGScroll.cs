using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{

    public float scrollSpeed;
    SpriteRenderer sr;
    float bgWidth;
    Vector3 screenEdge;
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        bgWidth = sr.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;
        screenEdge = Camera.main.ViewportToWorldPoint(new Vector3(0,0.5f,0));
        if (transform.position.x+bgWidth/2 < screenEdge.x)
        {
            Vector3 curPos = transform.position;

            curPos.x += 2 * bgWidth;
            transform.position = curPos;
        }
       
    }
}
