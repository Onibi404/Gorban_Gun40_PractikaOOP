using GamePrototype.Utils;

namespace GamePrototype.Items.EquipItems
{
    public sealed class Armour : EquipItem
    {
        
        private EquipSlot _slot;
        public Armour(uint defence, uint durability, string name, EquipSlot equipSlot) : base(durability, name)
        {
            Defence = defence;
            _slot = equipSlot;
        } 

        public uint Defence { get; }

        public override EquipSlot Slot => _slot;
        
    }
}
