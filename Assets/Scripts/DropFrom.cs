using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFrom : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject whereDrop;

    public void DropItem()
    {
        Instantiate(gameObject1, whereDrop.transform.position, whereDrop.transform.rotation);
    }
}
