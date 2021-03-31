using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefs : MonoBehaviour
{
    //For InventBG
    public Inventory Inventory;
    [SerializeField] RectTransform itemPanel;

    //For Save
    public GameObject GPopUp;
    public GameObject GPlayer;

    //For all
    public GameObject GCoins;

    private int coinCount;
    private string player;
    private string invent;

    public void Save()
    {
        coinCount = int.Parse(GCoins.name);
        PlayerPrefs.SetInt("Coins", coinCount);

        float px = GPlayer.transform.position.x;
        float pz = GPlayer.transform.position.z;
        float ry = GPlayer.transform.localRotation.eulerAngles.y;
        player = $"{px} {pz} {ry}";
        PlayerPrefs.SetString("Player", player);


        GameObject PanelItem;
        invent = "";
        PanelItem = GameObject.FindGameObjectWithTag("axe");
        if (PanelItem != null) invent += $"axe ";
        PanelItem = GameObject.FindGameObjectWithTag("shield");
        if (PanelItem != null) invent += $"shield ";
        PanelItem = GameObject.FindGameObjectWithTag("helmet");
        if (PanelItem != null) invent += $"helmet ";
        PanelItem = GameObject.FindGameObjectWithTag("sword");
        if (PanelItem != null) invent += $"sword ";
        PlayerPrefs.SetString("Inventory", invent);
        //PlayerPrefs.SetString("Inventory", "axe shield helmet sword");

        PlayerPrefs.Save();
        Instantiate(GPopUp);
    }
    private void Awake()
    {

        if (gameObject.name == "Player")
        {
            coinCount = PlayerPrefs.GetInt("Coins", 2);
            player = PlayerPrefs.GetString("Player", "0 0 0");

            GCoins.name = $"{coinCount}";

            string[] words1 = player.Split(new char[] { ' ' });
            float[] xyz = new float[3];
            for (int i = 0; i < 3; i++)
                xyz[i] = float.Parse(words1[i]);

            transform.rotation = Quaternion.Euler(0, xyz[2], 0);
            transform.position = new Vector3(xyz[0], -80, xyz[1]);
        }

        if (gameObject.name == "InventBG")
        {
            invent = PlayerPrefs.GetString("Inventory", "axe shield helmet sword");
            string[] words2 = invent.Split(new char[] { ' ' });

            foreach (var s in words2)
            {
                switch (s)
                {
                    case "axe":
                        Instantiate(Inventory.InventoryItems[0], itemPanel);
                        break;
                    case "shield":
                        Instantiate(Inventory.InventoryItems[1], itemPanel);
                        break;
                    case "helmet":
                        Instantiate(Inventory.InventoryItems[2], itemPanel);
                        break;
                    case "sword":
                        Instantiate(Inventory.InventoryItems[3], itemPanel);
                        break;
                }
            }
        }

    }
}
