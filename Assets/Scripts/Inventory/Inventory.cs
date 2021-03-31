using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<Item> StartItems = new List<Item>();
    public List<Item> InventoryItems { get; private set; }

    void Awake()
    {
        InventoryItems = new List<Item>();
        if (StartItems.Count > 0)
            for (var i = 0; i < StartItems.Count; i++)
                AddItem(StartItems[i]);
    }

    public void AddItem(Item item)
    {
        InventoryItems.Add(item);
    }
}