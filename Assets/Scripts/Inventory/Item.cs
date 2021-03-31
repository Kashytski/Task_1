using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public ItemInfo ItemInfo;
    public GameObject gameObject1;
    public GameObject gameObject2;
    public Text text;

    private void Start()
    {
        GetComponent<Image>().sprite = ItemInfo.Icon;
    }
    public void SetInfo()
    {
        if (gameObject1.activeInHierarchy == false)
        {
            gameObject1.SetActive(true);
            gameObject2.SetActive(true);
        }
            
        else
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(false);
        }

        text.text = $"{ItemInfo.Name}\n{ItemInfo.Price}";
    }

    public void Drop()
    {
        Destroy(gameObject);
    }
}