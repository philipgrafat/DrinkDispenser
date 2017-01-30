using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using ProtoBuf;

namespace DrinkDispenser.Model
{
    public sealed class DrinkDatabase
    {
        private Dictionary<string, Drink> _drinks;
        private readonly string _serializationFile = Properties.Settings.Default.DatabaseFile;

        public static readonly DrinkDatabase Instance = new DrinkDatabase(); // Singleton

        private DrinkDatabase()
        {
            if (File.Exists(_serializationFile))
            {
                // Get List of drinks from the file
                using (var file = File.OpenRead(_serializationFile))
                {
                    _drinks = Serializer.Deserialize<Dictionary<string, Drink>>(file);
                }
            }
            else
            {
                _drinks = new Dictionary<string, Drink>();
            }
        }

        public void Save()
        {
            using (var file = File.Create(_serializationFile))
            {
                Serializer.Serialize(file, _drinks);
            }
        }

        public Drink this[string name] => _drinks[name];
    }
}