using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private Transform content;
    [SerializeField] private UISlot slotPrefab;

    public void Start()
    {
        inventory.onInventoryChanged += UpdateUIInventory;
    }

    public void UpdateUIInventory()
    {
        var objs = content.GetComponentsInChildren<UISlot>();
        for (int i = 0; i < objs.Length; i++)
        {
            Destroy(objs[i].gameObject);
        }

        foreach (var item in inventory.storage.items)
        {
            UISlot slot = Instantiate(slotPrefab, content);
            slot.image.sprite = item.itemObject.ItemData.icon;
            if (item.itemObject.quantity > 1)
            {
                slot.text.text = item.itemObject.quantity.ToString();
            }
            else slot.text.text = "";
        }
        
    }
}
