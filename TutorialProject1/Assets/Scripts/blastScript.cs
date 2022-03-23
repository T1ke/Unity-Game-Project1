using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blastScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject blastEffect;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, 1.5f, transform.position.z);
        Instantiate(blastEffect, transform.position,blastEffect.transform.rotation);
        Destroy(gameObject);

    }
}
