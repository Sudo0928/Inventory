using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemTest : MonoBehaviour
{
    [Header("Inventory")]
    [SerializeField]
    private Inventory inventory;

    [Header ("아이템 ID")]
    [SerializeField]
    private int key;

    [Header("아이템 수량")]
    [SerializeField]
    private int quantity;

    public void AddItem()
    {
        ItemData data = DataManager.Instance.GetByKey(key);
        inventory.AddItem(data, quantity);
    }
}