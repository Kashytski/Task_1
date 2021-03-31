using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeCoin : MonoBehaviour
{
    public GameObject PopUp;
    GameObject gameObject1;

    public void Coin()
    {
        gameObject1 = GameObject.FindGameObjectWithTag("coins");
        int i1 = int.Parse(gameObject1.name);

        switch (gameObject.name)
        {
            case "CubeHeart":
                i1 += 15;
                StartCoroutine("Heart", i1);
                break;
            case "CubeMoney":
                i1 += 10;
                Money(i1);
                break;
            default:
                i1++;
                Money(i1);
                break;
        }
    }

    IEnumerator Heart(int i1)
    {
        yield return new WaitForSeconds(1.5f);
        gameObject1.name = $"{i1}";
        Instantiate(PopUp);
        Destroy(gameObject);
        StopCoroutine("Heart");
    }

    void Money(int i1)
    {
        gameObject1.name = $"{i1}";
        Instantiate(PopUp);
        Destroy(gameObject);
    }
}
