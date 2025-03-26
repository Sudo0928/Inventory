using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class EquipItemInfo
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
    /// ATK
    /// </summary>
    public int Atk;

    /// <summary>
    /// DEF
    /// </summary>
    public int Def;

    /// <summary>
    /// HP
    /// </summary>
    public int Hp;

    /// <summary>
    /// CRITICAL
    /// </summary>
    public int Critical;

    /// <summary>
    /// EquipType
    /// </summary>
    public DesignEnums.EquipType equipType;

}
public class EquipItemInfoLoader
{
    public List<EquipItemInfo> ItemsList { get; private set; }
    public Dictionary<int, EquipItemInfo> ItemsDict { get; private set; }

    public EquipItemInfoLoader(string path = "JSON/EquipItemInfo")
    {
        string jsonData;
        jsonData = Resources.Load<TextAsset>(path).text;
        ItemsList = JsonUtility.FromJson<Wrapper>(jsonData).Items;
        ItemsDict = new Dictionary<int, EquipItemInfo>();
        foreach (var item in ItemsList)
        {
            ItemsDict.Add(item.key, item);
        }
    }

    [Serializable]
    private class Wrapper
    {
        public List<EquipItemInfo> Items;
    }

    public EquipItemInfo GetByKey(int key)
    {
        if (ItemsDict.ContainsKey(key))
        {
            return ItemsDict[key];
        }
        return null;
    }
}
