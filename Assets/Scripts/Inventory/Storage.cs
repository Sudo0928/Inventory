using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Storage
{
    public int slotCount;
    public List<ItemInstance> items = new List<ItemInstance>();

    public Storage(int slotCount)
    {
        this.slotCount = slotCount;
    }

    public void AddItem(ItemData itemData, int quantity = 1)
    {
        if (itemData.maxStack > 1)
        {
            foreach (var instance in items)
            {
                if(instance.itemObject.quantity >= instance.itemObject.ItemData.maxStack) continue;

                if (instance.itemObject.ItemData.id == itemData.id)
                {
                    int total = instance.itemObject.quantity + quantity;
                    int max = itemData.maxStack;
                    if (total <= max)
                    {
                        instance.itemObject.quantity = total;
                        quantity = 0;
                    }
                    else
                    {
                        instance.itemObject.quantity = max;
                        quantity = total - max;
                    }
                }
            }

            while(quantity > 0)
            {
                if (items.Count >= slotCount) break;

                ItemInstance itemInstance;

                if(quantity <= itemData.maxStack)
                {
                    ItemObject itemObject = new ItemObject(itemData, quantity);
                    itemInstance = new ItemInstance(itemObject);
                    items.Add(itemInstance);
                    return;
                }
                else
                {
                    ItemObject itemObject = new ItemObject(itemData, itemData.maxStack);
                    itemInstance = new ItemInstance(itemObject);
                    items.Add(itemInstance);
                    quantity -= itemData.maxStack;
                }
            }
        }
    }
}
