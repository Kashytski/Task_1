using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCount : MonoBehaviour
{
    public Text text;

    void Update()
    {
        GameObject gameObject1 = GameObject.FindGameObjectWithTag("coins");
        text.text = $"{ gameObject1.name} coins";
    }
}
