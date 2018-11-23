namespace DungeonsAndCodeWizards.Entities.Bags
{
    public class Backpack : Bag
    {
        private const int defaultBagCapacity = 100;

        public Backpack() : base(capacity: defaultBagCapacity)
        {
        }
    }
}
