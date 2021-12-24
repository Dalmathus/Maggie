using Maggie.Models;
using Newtonsoft.Json;
using ScryfallApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maggie.Managers
{
    /// <summary>
    /// S: The purpose of this class is to save an Inventory to disk
    /// O: Existing methods saving to JSON my remain intact if I need to allow saving with encryption
    /// L: 
    /// </summary>
    internal class InventorySaver
    {
        public static void SaveInventoryToJSON(Inventory inventory, string filePath)
        {
            TextWriter? writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(inventory);
                writer = new StreamWriter(filePath);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
