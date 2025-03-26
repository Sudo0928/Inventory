using System;
using UnityEngine;
using static DesignEnums;

[Serializable]
public class ItemData
{
    public int id;
    public string description;
    public Sprite icon;
    public int maxStack;
    public ItemType itemType;

    public ItemData(ItemInfo info)
    {
        id = info.key;
        description = info.description;
        icon = Resources.Load<Sprite>(info.iconPath);
        maxStack = info.maxStack;
        itemType = info.itemType;
    }
}
