using System;

[Serializable]
public class ItemObject
{
    public ItemData ItemData { get; }
    public int quantity;

    public ItemObject(ItemData data, int quantity = 1)
    {
        ItemData = data;
        this.quantity = quantity;
    }
}
