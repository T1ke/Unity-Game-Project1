using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    new  Color[] colorArray = new Color[] { Color.red, Color.blue, Color.white, Color.green, Color.cyan };
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        int i = Random.Range(0, colorArray.Length);
        GetComponent<Renderer>().material.color = colorArray[i];

    }
}
