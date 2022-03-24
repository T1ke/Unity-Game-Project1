using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    public float smoothRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 playerPosition = player.position;
        Vector3 CameraPos = transform.position;
        CameraPos.x = Mathf.Lerp(CameraPos.x, playerPosition.x, smoothRate); //playerPosition.x;


        transform.position = CameraPos;//new Vector3();
    }
}
