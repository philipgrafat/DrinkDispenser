using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using ProtoBuf;

namespace DrinkDispenser.Model
{
    public class DrinkDatabase
    {
        private List<Drink> _drinks;
        private readonly string _serializationFile = Properties.Settings.Default.DatabaseFile;

        public DrinkDatabase()
        {
            if (File.Exists(_serializationFile))
            {
                // Get List of drinks from the file
                using (var file = File.OpenRead(_serializationFile))
                {
                    _drinks = Serializer.Deserialize<List<Drink>>(file);
                }
            }
            else
            {
                _drinks = new List<Drink>();
            }
        }

        public void Save()
        {
            using (var file = File.Create(_serializationFile))
            {
                Serializer.Serialize(file, _drinks);
            }
        }

        public Drink this[int index] => _drinks[index];
    }
}