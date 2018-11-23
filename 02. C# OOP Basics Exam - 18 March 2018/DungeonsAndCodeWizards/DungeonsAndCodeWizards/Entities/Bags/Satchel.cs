namespace DungeonsAndCodeWizards.Entities.Bags
{
    public class Satchel : Bag
    {
        private const int defaultBagCapacity = 20;

        public Satchel() : base(capacity: defaultBagCapacity)
        {
        }
    }
}
