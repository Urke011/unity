using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Vector3 cameraPos;

    void Start()
    {
        offset = transform.position - player.transform.position;
        cameraPos = transform.position;
    }


    void LateUpdate()
    {
        transform.position = new Vector3(
        player.transform.position.x + offset.x, cameraPos.y,
        cameraPos.z);
    }

}
