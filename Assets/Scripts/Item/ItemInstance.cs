using System;

[Serializable]
public class ItemInstance 
{
    public ItemObject itemObject;
    public UserData userData;
    public bool isEquiped = false;

    public ItemInstance(ItemObject itemObjectm, UserData userData = null)
    {
        this.itemObject = itemObjectm;
        this.userData = userData;
    }
}
