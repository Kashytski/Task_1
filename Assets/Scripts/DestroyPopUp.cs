using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPopUp : MonoBehaviour
{
    void Start()
    {
        Invoke("Destroy", 5);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
