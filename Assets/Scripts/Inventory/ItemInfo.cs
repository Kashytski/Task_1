using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Tutorial/Item")]
public class ItemInfo : ScriptableObject
{
    public string Name = "Item";
    public Sprite Icon;
    public int Price = 500;
}