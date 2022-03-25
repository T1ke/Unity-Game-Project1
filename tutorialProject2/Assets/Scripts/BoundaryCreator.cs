using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryCreator : MonoBehaviour
{
    public GameObject leftEdge;
    public GameObject rightEdge;
    public GameObject TopEdge;
    public GameObject BottomEdge;

    //Camera cam = Camera.main.gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AutoPosition();
    }

    void AutoPosition()
    {
        leftEdge.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.5f, 10f));
        rightEdge.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(1, 0.5f, 10f));
        TopEdge.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1f, 10f));
        BottomEdge.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0, 10f));

    }
}
