using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public GameObject inventary;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            if (inventary.activeInHierarchy == false)
                inventary.SetActive(true);
            else inventary.SetActive(false);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * 200 * verticalInput);
        transform.Rotate(Vector3.up , Time.deltaTime * 200 * horizontalInput);
    }
}
