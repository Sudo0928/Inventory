using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class ItemInfo
{
    /// <summary>
    /// ID
    /// </summary>
    public int key;

    /// <summary>
    /// Name
    /// </summary>
    public string name;

    /// <summary>
    /// Description
    /// </summary>
    public string description;

    /// <summary>
    /// IconPath
    /// </summary>
    public string iconPath;

    /// <summary>
    /// MaxStack
    /// </summary>
    public int maxStack;

    /// <summary>
    /// ItemType
    /// </summary>
    public DesignEnums.ItemType itemType;

}
public class ItemInfoLoader
{
    public List<ItemInfo> ItemsList { get; private set; }
    public Dictionary<int, ItemInfo> ItemsDict { get; private set; }

    public ItemInfoLoader(string path = "JSON/ItemInfo")
    {
        string jsonData;
        jsonData = Resources.Load<TextAsset>(path).text;
        ItemsList = JsonUtility.FromJson<Wrapper>(jsonData).Items;
        ItemsDict = new Dictionary<int, ItemInfo>();
        foreach (var item in ItemsList)
        {
            ItemsDict.Add(item.key, item);
        }
    }

    [Serializable]
    private class Wrapper
    {
        public List<ItemInfo> Items;
    }

    public ItemInfo GetByKey(int key)
    {
        if (ItemsDict.ContainsKey(key))
        {
            return ItemsDict[key];
        }
        return null;
    }
}
