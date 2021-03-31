using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int power;
    public GameObject ExplosionEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (power < 6)
        {
            Destroy(gameObject);
            Instantiate(ExplosionEffect,transform.position,transform.rotation);
            Debug.Log($"{gameObject.name} is broken");
        }    
    }
}
