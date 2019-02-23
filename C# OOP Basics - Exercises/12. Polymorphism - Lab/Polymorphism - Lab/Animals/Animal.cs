namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string FavouriteFood { get; set; }

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}