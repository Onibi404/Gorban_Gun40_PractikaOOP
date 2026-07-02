namespace GamePrototype.Items.EconomicItems
{
    public sealed class Grindstone : EconomicItem
    {
        public override bool Stackable => false;
        
        public uint ReparingValue { get; private set; }

        public Grindstone(string name) : base(name)
        {
        }    
    }
}
