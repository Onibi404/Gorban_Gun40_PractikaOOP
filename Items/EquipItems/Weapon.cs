using GamePrototype.Utils;

namespace GamePrototype.Items.EquipItems
{
    public sealed class Weapon : EquipItem
    {
        private EquipSlot _slot;

        public Weapon(uint damage, uint durability, string name, EquipSlot equipSlot) : base(durability, name)
        {
            Damage = damage;
            _slot = equipSlot;
        }

        public uint Damage { get; }

        public override EquipSlot Slot => _slot;
    }
}
