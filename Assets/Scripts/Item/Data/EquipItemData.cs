using System;
using static DesignEnums;

[Serializable]
public class EquipItemData : ItemData
{
    public EquipType equipType;
    public int atk;
    public int def;
    public int hp;
    public int critical;

    public EquipItemData(ItemInfo info, EquipItemInfo equipInfo) : base(info)
    {
        equipType = equipInfo.equipType;
        atk = equipInfo.Atk;
        def = equipInfo.Def;
        hp = equipInfo.Hp;
        critical = equipInfo.Critical;
    }
}
