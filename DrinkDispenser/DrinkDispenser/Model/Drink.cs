namespace DrinkDispenser.Model
{
    public struct Drink
    {
        /// <summary>
        /// The amount of available bottles.
        /// </summary>
        public int Amount;

        /// <summary>
        /// The filling quantity in mililiters.
        /// </summary>
        public readonly int FillingQuantity;

        /// <summary>
        /// The name of the drink
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Drink"/> struct.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="fillingQuantity">The filling quantity.</param>
        /// <param name="amount">The amount.</param>
        public Drink(string name, int fillingQuantity, int amount)
        {
            Name = name;
            FillingQuantity = fillingQuantity;
            Amount = amount;
        }
    }
}