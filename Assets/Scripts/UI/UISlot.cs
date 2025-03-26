using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public ItemInstance ItemInstance;
    public Image image;
    public TextMeshProUGUI text;

    public void OnClickItem()
    {
        if(ItemInstance.itemObject.ItemData.itemType == DesignEnums.ItemType.Equip)
        {
            ItemInstance.isEquiped = !ItemInstance.isEquiped;

            if (ItemInstance.isEquiped) text.text = "E";
            else text.text = "";
        }
    }
}
