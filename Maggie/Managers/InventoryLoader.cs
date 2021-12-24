using Maggie.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maggie.Managers
{
    /// <summary>
    /// S: The responsiblity of this class is to load an 'Inventory' into memory
    /// O: 
    /// L:
    /// I:
    /// D:
    /// </summary>
    internal class InventoryLoader
    {
        public static Inventory? LoadInventoryFromJSON(string filePath)
        {
            TextReader? reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Inventory>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
