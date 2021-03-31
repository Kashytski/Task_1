using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        gameObject.transform.position = player.transform.position;
        gameObject.transform.rotation = player.transform.rotation;
    }
}
