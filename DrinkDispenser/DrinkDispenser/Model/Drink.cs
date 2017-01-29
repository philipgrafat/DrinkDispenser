using ProtoBuf;

namespace DrinkDispenser.Model
{
    [ProtoContract]
    public struct Drink
    {
        /// <summary>
        /// The amount of available bottles.
        /// </summary>
        [ProtoMember(1)]
        public int Amount;

        /// <summary>
        /// The filling quantity in mililiters.
        /// </summary>
        [ProtoMember(2)]
        public readonly int FillingQuantity;

        /// <summary>
        /// The name of the drink
        /// </summary>
        [ProtoMember(3)]
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

        public override string ToString()
        {
            return $"{Name} {FillingQuantity}ml";
        }
    }
}