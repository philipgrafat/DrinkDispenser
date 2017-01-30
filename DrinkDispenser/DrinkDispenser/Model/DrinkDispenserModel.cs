using System;

namespace DrinkDispenser.Model
{
    public class DrinkDispenserModel
    {
        private DrinkDatabase _database;
        public DrinkDispenserModel()
        {
            _database = DrinkDatabase.Instance;
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}