using System;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Storage storage;

    public event Action onInventoryChanged;

    public void Init()
    {
        storage = new Storage(10);
    }

    public void AddItem(ItemData itemData, int quantity = 1)
    {
        storage.AddItem(itemData, quantity);
        onInventoryChanged?.Invoke();
    }
}
