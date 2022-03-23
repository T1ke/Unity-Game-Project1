using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptObject : MonoBehaviour
{
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.D) && Physics.Raycast(mouseRay, out hit))
        {
            Debug.Log("Osuma");
            Debug.Log(hit.collider.name);
            Destroy(hit.collider.gameObject,1);

        }
    }
}
