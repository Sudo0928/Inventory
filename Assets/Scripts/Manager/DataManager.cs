using System.Collections.Generic;

public class DataManager : Singleton<DataManager>
{
    private ItemInfoLoader itemInfoLoader;
    private EquipItemInfoLoader equipItemInfoLoader;

    private Dictionary<int, ItemData> itemDatas = new Dictionary<int, ItemData>();

    public void Awake()
    {
        itemInfoLoader = new ItemInfoLoader();
        equipItemInfoLoader = new EquipItemInfoLoader();
    }

    public ItemData GetByKey(int key)
    {
        if (itemDatas.ContainsKey(key))
        {
            return itemDatas[key];
        }

        ItemInfo itemInfo = itemInfoLoader.GetByKey(key);

        switch (itemInfo.itemType)
        {
            case DesignEnums.ItemType.Equip:
                EquipItemInfo equipItemInfo = equipItemInfoLoader.GetByKey(key);
                EquipItemData equipItemData = new EquipItemData(itemInfo, equipItemInfo);
                itemDatas.Add(key, equipItemData);
                break;
            default:
                ItemData itemData = new ItemData(itemInfo);
                itemDatas.Add(key, itemData);
                break;
        }

        return itemDatas[key];
    }
}
