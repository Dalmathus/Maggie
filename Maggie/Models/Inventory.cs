using Newtonsoft.Json;
using ScryfallApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maggie.Models
{
    /// <summary>
    /// S: The purpose of this class is to define an Inventory in memory
    /// O:
    /// L:
    /// I:
    /// D:
    /// </summary>
    public class Inventory
    {
        [JsonProperty]
        private List<Card>? _cards;

        public Inventory()
        {
            _cards = new List<Card>();
        }

        public void Add(Card c)
        {
            if (_cards != null)
            {
                _cards.Add(c);
            }
        }

        public void Delete(Card c)
        {
            if (_cards != null)
            {
                _cards.Remove(c);
            }
        }
    }
}