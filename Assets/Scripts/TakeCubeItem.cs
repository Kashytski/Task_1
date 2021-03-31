using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeCubeItem : MonoBehaviour
{
    public Item item;
    public void Take()
    {
        if (item != null)
        {
            GameObject gameObject1 = GameObject.FindGameObjectWithTag("Panel");
            RectTransform gameObject2 = gameObject1.GetComponent<RectTransform>();

            Instantiate(item, gameObject2);
            Destroy(gameObject);
        }

    }
}
